using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace rabi_splitter_WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainContext mainContext;
        private RabiRibiDisplay rabiRibiDisplay;
        private DebugContext debugContext;
        private VariableExportContext variableExportContext;
        private static TcpClient tcpclient;
        private static NetworkStream networkStream;
        private readonly Regex titleReg = new Regex(@"ver.*?(\d+\.?\d+.*)$");
        private readonly Thread memoryThread;
        
        private void ReadMemory()
        {
            var processlist = Process.GetProcessesByName("rabiribi");
            if (processlist.Length > 0)
            {
                Process process = processlist[0];
                if (process.MainWindowTitle != mainContext.oldtitle)
                {
                    var result = titleReg.Match(process.MainWindowTitle);
                    string rabiver;
                    if (result.Success)
                    {
                        rabiver = result.Groups[1].Value;
                        mainContext.veridx = Array.IndexOf(StaticData.VerNames, rabiver);
                        if (mainContext.veridx < 0)
                        {
                            mainContext.GameVer = rabiver + " Running (not supported)";
                            return;
                        }
                    }
                    else
                    {
                        mainContext.veridx = -1;
                        mainContext.GameVer = "Running (Unknown version)";
                        return;
                    }
                    mainContext.GameVer = rabiver + " Running";
                    mainContext.oldtitle = process.MainWindowTitle;
                }
                
                if (mainContext.veridx < 0) return;

                rabiRibiDisplay.ReadMemory(process);
            }
            else
            {
                mainContext.oldtitle = "";
                mainContext.GameVer = "Not Found";
                mainContext.GameMusic = "N/A";
            }
        }
        
        public void SendMessage(string message)
        {
            if (tcpclient != null && tcpclient.Connected)
            {
                try
                {
                    var b = Encoding.UTF8.GetBytes(message);
                    networkStream.Write(b, 0, b.Length);
                }
                catch (Exception)
                {

                    disconnect();
                }
            }
        }

        void disconnect()
        {
            tcpclient = null;
            this.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() =>
            {
                BtnConnect.IsEnabled = true;
            }));
        }

        private void DebugLog(string log)
        {
            this.debugContext.Log(log);
        }

        public MainWindow()
        {
            InitializeComponent();
            mainContext=new MainContext();
            debugContext=new DebugContext();
            variableExportContext = new VariableExportContext();
            this.DataContext = mainContext;
            DebugPanel.DataContext = debugContext;
            this.Grid.ItemsSource = debugContext.BossList;
            EntityDataPanel.DataContext = debugContext;
            this.EntityStats.ItemsSource = debugContext.EntityStatsListView;
            this.VariableExportTab.DataContext = variableExportContext;
            this.VariableExportTab.Initialise(debugContext, variableExportContext);
            BossEventDebug.DataContext = debugContext;
            rabiRibiDisplay = new RabiRibiDisplay(mainContext, debugContext, variableExportContext, this);
            memoryThread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        ReadMemory();
                    }
                    catch (Exception e)
                    {
                        DebugLog(e.ToString());
                    }
                   
                    Thread.Sleep(1000 / 60);
                }

            });
            memoryThread.IsBackground = true;
            memoryThread.Start();
        }

        private void BtnConnect_Click(object sender, RoutedEventArgs e)
        {
            if (tcpclient != null && tcpclient.Connected) return;
            try
            {
                tcpclient = new TcpClient("127.0.0.1", Convert.ToInt32(mainContext.ServerPort));
                networkStream = tcpclient.GetStream();
                this.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() =>
                {
                    BtnConnect.IsEnabled = false;
                }));
            }
            catch (Exception)
            {
                tcpclient = null;
                networkStream = null;
                MessageBox.Show(this, "Connect Failed");

            }
        }

        private void TextBlock_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://github.com/copyliu/rabiribi_splitter");
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var s = sender as TextBox;
            if (s != null)
            {
                s.ScrollToEnd();
            }
        }

        private void CommandButton_Click(object sender, RoutedEventArgs e)
        {
            var userInput = SpawnMessageBox("Input Command");
            if (userInput == null) return;
            debugContext.Log($">>> {userInput}");

            var args = userInput.Split();
            if (args.Length < 1) return;

            string errorMessage = null;
            switch (args[0])
            {
                case "set":
                    if (args.Length < 3)
                    {
                        errorMessage = "Invalid Format. Expected 'set <varname> <value>'";
                        break;
                    }
                    errorMessage = rabiRibiDisplay.TrySetProperty(args[1], args[2]);
                    break;
                default:
                    errorMessage = "Invalid Command";
                    break;
            }
            if (errorMessage != null) {
                debugContext.Log(errorMessage);
            }
        }
        
        private string SpawnMessageBox(string label)
        {
            var dialog = new System.Windows.Forms.Form()
            {
                Height = 105,
                Width = 340,
                StartPosition = System.Windows.Forms.FormStartPosition.CenterParent,
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
            };

            var textLabel = new System.Windows.Forms.Label() { Left = 0, Top = 0, Width = 320, Text = label, TextAlign = System.Drawing.ContentAlignment.MiddleCenter };
            var textBox = new System.Windows.Forms.TextBox() { Left = 10, Top = 20, Width = 300 };
            var cancelButton = new System.Windows.Forms.Button() { Text = "Cancel", Left = 70, Width = 80, Top = 40, DialogResult = System.Windows.Forms.DialogResult.Cancel };
            var confirmButton = new System.Windows.Forms.Button() { Text = "Ok", Left = 170, Width = 80, Top = 40, DialogResult = System.Windows.Forms.DialogResult.OK };
            cancelButton.Click += (s, e) => { dialog.Close(); };
            confirmButton.Click += (s, e) => { dialog.Close(); };
            dialog.Controls.Add(textBox);
            dialog.Controls.Add(textLabel);
            dialog.Controls.Add(cancelButton);
            dialog.Controls.Add(confirmButton);
            dialog.CancelButton = cancelButton;
            dialog.AcceptButton = confirmButton;
            
            string userInput;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                userInput = textBox.Text;
            }
            else
            {
                userInput = null;
            }
            dialog.Dispose();

            return userInput;
        }
    }
}
