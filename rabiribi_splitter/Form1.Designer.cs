﻿namespace rabiribi_splitter
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rbStatus = new System.Windows.Forms.Label();
            this.portNum = new System.Windows.Forms.NumericUpDown();
            this.cbBossStart = new System.Windows.Forms.CheckBox();
            this.cbBossEnd = new System.Windows.Forms.CheckBox();
            this.musicLabel = new System.Windows.Forms.Label();
            this.cbBoss = new System.Windows.Forms.CheckBox();
            this.cbComputer = new System.Windows.Forms.CheckBox();
            this.cbBoss1 = new System.Windows.Forms.CheckBox();
            this.cbBoss3 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.t1 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.portNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "LiveSplit Server Port:";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(212, 8);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 4;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rabi-Ribi Status:";
            // 
            // rbStatus
            // 
            this.rbStatus.AutoSize = true;
            this.rbStatus.Location = new System.Drawing.Point(126, 37);
            this.rbStatus.Name = "rbStatus";
            this.rbStatus.Size = new System.Drawing.Size(41, 12);
            this.rbStatus.TabIndex = 6;
            this.rbStatus.Text = "label4";
            // 
            // portNum
            // 
            this.portNum.Location = new System.Drawing.Point(149, 9);
            this.portNum.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.portNum.Name = "portNum";
            this.portNum.Size = new System.Drawing.Size(57, 21);
            this.portNum.TabIndex = 11;
            this.portNum.Value = new decimal(new int[] {
            16834,
            0,
            0,
            0});
            // 
            // cbBossStart
            // 
            this.cbBossStart.AutoSize = true;
            this.cbBossStart.Location = new System.Drawing.Point(15, 53);
            this.cbBossStart.Name = "cbBossStart";
            this.cbBossStart.Size = new System.Drawing.Size(192, 16);
            this.cbBossStart.TabIndex = 12;
            this.cbBossStart.Text = "Split when BOSS music STARTS";
            this.cbBossStart.UseVisualStyleBackColor = true;
            // 
            // cbBossEnd
            // 
            this.cbBossEnd.AutoSize = true;
            this.cbBossEnd.Checked = true;
            this.cbBossEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBossEnd.Location = new System.Drawing.Point(15, 75);
            this.cbBossEnd.Name = "cbBossEnd";
            this.cbBossEnd.Size = new System.Drawing.Size(180, 16);
            this.cbBossEnd.TabIndex = 13;
            this.cbBossEnd.Text = "Split when BOSS music ENDS";
            this.cbBossEnd.UseVisualStyleBackColor = true;
            // 
            // musicLabel
            // 
            this.musicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.musicLabel.AutoSize = true;
            this.musicLabel.Location = new System.Drawing.Point(13, 477);
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(41, 12);
            this.musicLabel.TabIndex = 14;
            this.musicLabel.Text = "label1";
            // 
            // cbBoss
            // 
            this.cbBoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbBoss.AutoSize = true;
            this.cbBoss.Enabled = false;
            this.cbBoss.Location = new System.Drawing.Point(15, 492);
            this.cbBoss.Name = "cbBoss";
            this.cbBoss.Size = new System.Drawing.Size(84, 16);
            this.cbBoss.TabIndex = 15;
            this.cbBoss.Text = "BOSS event";
            this.cbBoss.UseVisualStyleBackColor = true;
            // 
            // cbComputer
            // 
            this.cbComputer.AutoSize = true;
            this.cbComputer.Checked = true;
            this.cbComputer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbComputer.Location = new System.Drawing.Point(15, 97);
            this.cbComputer.Name = "cbComputer";
            this.cbComputer.Size = new System.Drawing.Size(192, 16);
            this.cbComputer.TabIndex = 16;
            this.cbComputer.Text = "Split when find the computer";
            this.cbComputer.UseVisualStyleBackColor = true;
            // 
            // cbBoss1
            // 
            this.cbBoss1.AutoSize = true;
            this.cbBoss1.Checked = true;
            this.cbBoss1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBoss1.Location = new System.Drawing.Point(15, 119);
            this.cbBoss1.Name = "cbBoss1";
            this.cbBoss1.Size = new System.Drawing.Size(318, 16);
            this.cbBoss1.TabIndex = 17;
            this.cbBoss1.Text = "Split when Miru/Nixie despawn, ignore their music";
            this.cbBoss1.UseVisualStyleBackColor = true;
            // 
            // cbBoss3
            // 
            this.cbBoss3.AutoSize = true;
            this.cbBoss3.Checked = true;
            this.cbBoss3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBoss3.Location = new System.Drawing.Point(15, 141);
            this.cbBoss3.Name = "cbBoss3";
            this.cbBoss3.Size = new System.Drawing.Size(276, 16);
            this.cbBoss3.TabIndex = 19;
            this.cbBoss3.Text = "Split when Noah 3 HP = 0, ignore her music";
            this.cbBoss3.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(804, 496);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 12);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub";
            // 
            // t1
            // 
            this.t1.AutoSize = true;
            this.t1.Location = new System.Drawing.Point(498, 37);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(41, 12);
            this.t1.TabIndex = 21;
            this.t1.Text = "label1";
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.Location = new System.Drawing.Point(694, 36);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(41, 12);
            this.t2.TabIndex = 22;
            this.t2.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "DebugArea";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cbBoss3);
            this.Controls.Add(this.cbBoss1);
            this.Controls.Add(this.cbComputer);
            this.Controls.Add(this.cbBoss);
            this.Controls.Add(this.musicLabel);
            this.Controls.Add(this.cbBossEnd);
            this.Controls.Add(this.cbBossStart);
            this.Controls.Add(this.portNum);
            this.Controls.Add(this.rbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Irisu is watching you";
            ((System.ComponentModel.ISupportInitialize)(this.portNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rbStatus;
        private System.Windows.Forms.NumericUpDown portNum;
        private System.Windows.Forms.CheckBox cbBossStart;
        private System.Windows.Forms.CheckBox cbBossEnd;
        private System.Windows.Forms.Label musicLabel;
        private System.Windows.Forms.CheckBox cbBoss;
        private System.Windows.Forms.CheckBox cbComputer;
        private System.Windows.Forms.CheckBox cbBoss1;
        private System.Windows.Forms.CheckBox cbBoss3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label t1;
        private System.Windows.Forms.Label t2;
        private System.Windows.Forms.Label label1;
    }
}

