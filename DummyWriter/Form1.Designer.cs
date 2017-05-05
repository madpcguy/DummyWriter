namespace DummyWriter
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtWritePath = new System.Windows.Forms.TextBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.grpBoxSize = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboWriteSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtByteSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoGByte = new System.Windows.Forms.RadioButton();
            this.rdoMByte = new System.Windows.Forms.RadioButton();
            this.rdoKByte = new System.Windows.Forms.RadioButton();
            this.rdoByte = new System.Windows.Forms.RadioButton();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.lblOpenFilePath = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkDelOnClose = new System.Windows.Forms.CheckBox();
            this.grpBoxWriteOption = new System.Windows.Forms.GroupBox();
            this.chkSameValInBlock = new System.Windows.Forms.CheckBox();
            this.chkWriteThrough = new System.Windows.Forms.CheckBox();
            this.chkUseSeek = new System.Windows.Forms.CheckBox();
            this.chkRandPerBlock = new System.Windows.Forms.CheckBox();
            this.rdoBuffRand = new System.Windows.Forms.RadioButton();
            this.rdoBuffZero = new System.Windows.Forms.RadioButton();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.grpBoxSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.grpBoxWriteOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "書き込みパス：";
            // 
            // txtWritePath
            // 
            this.txtWritePath.Location = new System.Drawing.Point(92, 9);
            this.txtWritePath.Name = "txtWritePath";
            this.txtWritePath.Size = new System.Drawing.Size(206, 19);
            this.txtWritePath.TabIndex = 1;
            this.txtWritePath.Text = "F:\\";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(304, 9);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(27, 19);
            this.btnSelectPath.TabIndex = 2;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(15, 85);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 41);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(96, 85);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 41);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Enabled = false;
            this.btnWrite.Location = new System.Drawing.Point(177, 85);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 41);
            this.btnWrite.TabIndex = 5;
            this.btnWrite.Text = "WRITE";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnSync
            // 
            this.btnSync.Enabled = false;
            this.btnSync.Location = new System.Drawing.Point(258, 85);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 41);
            this.btnSync.TabIndex = 6;
            this.btnSync.Text = "SYNC";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // grpBoxSize
            // 
            this.grpBoxSize.Controls.Add(this.label6);
            this.grpBoxSize.Controls.Add(this.label5);
            this.grpBoxSize.Controls.Add(this.comboWriteSize);
            this.grpBoxSize.Controls.Add(this.label3);
            this.grpBoxSize.Controls.Add(this.txtByteSize);
            this.grpBoxSize.Controls.Add(this.label2);
            this.grpBoxSize.Controls.Add(this.rdoGByte);
            this.grpBoxSize.Controls.Add(this.rdoMByte);
            this.grpBoxSize.Controls.Add(this.rdoKByte);
            this.grpBoxSize.Controls.Add(this.rdoByte);
            this.grpBoxSize.Controls.Add(this.numSize);
            this.grpBoxSize.Location = new System.Drawing.Point(15, 132);
            this.grpBoxSize.Name = "grpBoxSize";
            this.grpBoxSize.Size = new System.Drawing.Size(315, 113);
            this.grpBoxSize.TabIndex = 16;
            this.grpBoxSize.TabStop = false;
            this.grpBoxSize.Text = "書き込みサイズ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "Byte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "書込ブロックサイズ：";
            // 
            // comboWriteSize
            // 
            this.comboWriteSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWriteSize.Location = new System.Drawing.Point(119, 73);
            this.comboWriteSize.Name = "comboWriteSize";
            this.comboWriteSize.Size = new System.Drawing.Size(150, 20);
            this.comboWriteSize.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "Byte";
            // 
            // txtByteSize
            // 
            this.txtByteSize.Location = new System.Drawing.Point(98, 48);
            this.txtByteSize.Name = "txtByteSize";
            this.txtByteSize.ReadOnly = true;
            this.txtByteSize.Size = new System.Drawing.Size(171, 19);
            this.txtByteSize.TabIndex = 26;
            this.txtByteSize.Text = "1024";
            this.txtByteSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "実書込サイズ：";
            // 
            // rdoGByte
            // 
            this.rdoGByte.AutoSize = true;
            this.rdoGByte.Location = new System.Drawing.Point(265, 18);
            this.rdoGByte.Name = "rdoGByte";
            this.rdoGByte.Size = new System.Drawing.Size(39, 16);
            this.rdoGByte.TabIndex = 20;
            this.rdoGByte.Tag = 1073741824;
            this.rdoGByte.Text = "GB";
            this.rdoGByte.UseVisualStyleBackColor = true;
            this.rdoGByte.CheckedChanged += new System.EventHandler(this.rdoSize_CheckedChanged);
            // 
            // rdoMByte
            // 
            this.rdoMByte.AutoSize = true;
            this.rdoMByte.Location = new System.Drawing.Point(219, 18);
            this.rdoMByte.Name = "rdoMByte";
            this.rdoMByte.Size = new System.Drawing.Size(40, 16);
            this.rdoMByte.TabIndex = 19;
            this.rdoMByte.Tag = 1048576;
            this.rdoMByte.Text = "MB";
            this.rdoMByte.UseVisualStyleBackColor = true;
            this.rdoMByte.CheckedChanged += new System.EventHandler(this.rdoSize_CheckedChanged);
            // 
            // rdoKByte
            // 
            this.rdoKByte.AutoSize = true;
            this.rdoKByte.Checked = true;
            this.rdoKByte.Location = new System.Drawing.Point(175, 18);
            this.rdoKByte.Name = "rdoKByte";
            this.rdoKByte.Size = new System.Drawing.Size(38, 16);
            this.rdoKByte.TabIndex = 18;
            this.rdoKByte.TabStop = true;
            this.rdoKByte.Tag = 1024;
            this.rdoKByte.Text = "KB";
            this.rdoKByte.UseVisualStyleBackColor = true;
            this.rdoKByte.CheckedChanged += new System.EventHandler(this.rdoSize_CheckedChanged);
            // 
            // rdoByte
            // 
            this.rdoByte.AutoSize = true;
            this.rdoByte.Location = new System.Drawing.Point(138, 18);
            this.rdoByte.Name = "rdoByte";
            this.rdoByte.Size = new System.Drawing.Size(31, 16);
            this.rdoByte.TabIndex = 17;
            this.rdoByte.Tag = 1;
            this.rdoByte.Text = "B";
            this.rdoByte.UseVisualStyleBackColor = true;
            this.rdoByte.CheckedChanged += new System.EventHandler(this.rdoSize_CheckedChanged);
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(13, 18);
            this.numSize.Maximum = new decimal(new int[] {
            102400,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(120, 19);
            this.numSize.TabIndex = 16;
            this.numSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.ValueChanged += new System.EventHandler(this.rdoSize_CheckedChanged);
            // 
            // lblOpenFilePath
            // 
            this.lblOpenFilePath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOpenFilePath.Location = new System.Drawing.Point(92, 40);
            this.lblOpenFilePath.Name = "lblOpenFilePath";
            this.lblOpenFilePath.Size = new System.Drawing.Size(238, 17);
            this.lblOpenFilePath.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "一時ファイル名：";
            // 
            // chkDelOnClose
            // 
            this.chkDelOnClose.AutoSize = true;
            this.chkDelOnClose.Location = new System.Drawing.Point(15, 63);
            this.chkDelOnClose.Name = "chkDelOnClose";
            this.chkDelOnClose.Size = new System.Drawing.Size(125, 16);
            this.chkDelOnClose.TabIndex = 20;
            this.chkDelOnClose.Text = "クローズ時に削除する";
            this.chkDelOnClose.UseVisualStyleBackColor = true;
            // 
            // grpBoxWriteOption
            // 
            this.grpBoxWriteOption.Controls.Add(this.chkSameValInBlock);
            this.grpBoxWriteOption.Controls.Add(this.chkWriteThrough);
            this.grpBoxWriteOption.Controls.Add(this.chkUseSeek);
            this.grpBoxWriteOption.Controls.Add(this.chkRandPerBlock);
            this.grpBoxWriteOption.Controls.Add(this.rdoBuffRand);
            this.grpBoxWriteOption.Controls.Add(this.rdoBuffZero);
            this.grpBoxWriteOption.Location = new System.Drawing.Point(15, 261);
            this.grpBoxWriteOption.Name = "grpBoxWriteOption";
            this.grpBoxWriteOption.Size = new System.Drawing.Size(314, 119);
            this.grpBoxWriteOption.TabIndex = 21;
            this.grpBoxWriteOption.TabStop = false;
            this.grpBoxWriteOption.Text = "書込みオプション";
            // 
            // chkSameValInBlock
            // 
            this.chkSameValInBlock.AutoSize = true;
            this.chkSameValInBlock.Location = new System.Drawing.Point(126, 40);
            this.chkSameValInBlock.Name = "chkSameValInBlock";
            this.chkSameValInBlock.Size = new System.Drawing.Size(105, 16);
            this.chkSameValInBlock.TabIndex = 5;
            this.chkSameValInBlock.Text = "ブロック内同一値";
            this.chkSameValInBlock.UseVisualStyleBackColor = true;
            // 
            // chkWriteThrough
            // 
            this.chkWriteThrough.AutoSize = true;
            this.chkWriteThrough.Location = new System.Drawing.Point(13, 84);
            this.chkWriteThrough.Name = "chkWriteThrough";
            this.chkWriteThrough.Size = new System.Drawing.Size(91, 16);
            this.chkWriteThrough.TabIndex = 4;
            this.chkWriteThrough.Text = "WriteThrough";
            this.chkWriteThrough.UseVisualStyleBackColor = true;
            // 
            // chkUseSeek
            // 
            this.chkUseSeek.AutoSize = true;
            this.chkUseSeek.Checked = true;
            this.chkUseSeek.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseSeek.Location = new System.Drawing.Point(13, 62);
            this.chkUseSeek.Name = "chkUseSeek";
            this.chkUseSeek.Size = new System.Drawing.Size(215, 16);
            this.chkUseSeek.TabIndex = 3;
            this.chkUseSeek.Text = "WRITEボタン押下時に先頭から書き込む";
            this.chkUseSeek.UseVisualStyleBackColor = true;
            // 
            // chkRandPerBlock
            // 
            this.chkRandPerBlock.AutoSize = true;
            this.chkRandPerBlock.Location = new System.Drawing.Point(126, 18);
            this.chkRandPerBlock.Name = "chkRandPerBlock";
            this.chkRandPerBlock.Size = new System.Drawing.Size(114, 16);
            this.chkRandPerBlock.TabIndex = 2;
            this.chkRandPerBlock.Text = "ブロック毎にランダム";
            this.chkRandPerBlock.UseVisualStyleBackColor = true;
            // 
            // rdoBuffRand
            // 
            this.rdoBuffRand.AutoSize = true;
            this.rdoBuffRand.Checked = true;
            this.rdoBuffRand.Location = new System.Drawing.Point(61, 18);
            this.rdoBuffRand.Name = "rdoBuffRand";
            this.rdoBuffRand.Size = new System.Drawing.Size(59, 16);
            this.rdoBuffRand.TabIndex = 1;
            this.rdoBuffRand.TabStop = true;
            this.rdoBuffRand.Text = "ランダム";
            this.rdoBuffRand.UseVisualStyleBackColor = true;
            this.rdoBuffRand.CheckedChanged += new System.EventHandler(this.rdoBuffRandChkbox_CheckedChanged);
            // 
            // rdoBuffZero
            // 
            this.rdoBuffZero.AutoSize = true;
            this.rdoBuffZero.Location = new System.Drawing.Point(13, 18);
            this.rdoBuffZero.Name = "rdoBuffZero";
            this.rdoBuffZero.Size = new System.Drawing.Size(42, 16);
            this.rdoBuffZero.TabIndex = 0;
            this.rdoBuffZero.Text = "ゼロ";
            this.rdoBuffZero.UseVisualStyleBackColor = true;
            this.rdoBuffZero.CheckedChanged += new System.EventHandler(this.rdoBuffRandChkbox_CheckedChanged);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(14, 386);
            this.txtLog.MaxLength = 0;
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(316, 77);
            this.txtLog.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 477);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.grpBoxWriteOption);
            this.Controls.Add(this.chkDelOnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOpenFilePath);
            this.Controls.Add(this.grpBoxSize);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.txtWritePath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DummyWriter";
            this.grpBoxSize.ResumeLayout(false);
            this.grpBoxSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.grpBoxWriteOption.ResumeLayout(false);
            this.grpBoxWriteOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWritePath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.GroupBox grpBoxSize;
        private System.Windows.Forms.RadioButton rdoGByte;
        private System.Windows.Forms.RadioButton rdoMByte;
        private System.Windows.Forms.RadioButton rdoKByte;
        private System.Windows.Forms.RadioButton rdoByte;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtByteSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOpenFilePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboWriteSize;
        private System.Windows.Forms.CheckBox chkDelOnClose;
        private System.Windows.Forms.GroupBox grpBoxWriteOption;
        private System.Windows.Forms.RadioButton rdoBuffRand;
        private System.Windows.Forms.RadioButton rdoBuffZero;
        private System.Windows.Forms.CheckBox chkRandPerBlock;
        private System.Windows.Forms.CheckBox chkUseSeek;
        private System.Windows.Forms.CheckBox chkWriteThrough;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.CheckBox chkSameValInBlock;
    }
}

