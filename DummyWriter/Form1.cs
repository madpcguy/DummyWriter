using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DummyWriter
{
    public partial class Form1 : Form
    {
        ulong writeSize = 1024;
        FileStream tmpFile;
        Task writeTask;
        CancellationTokenSource cancelTokenSource;
        Random rand = new Random();
        byte lastVal = 0;

        List<Control> changeCtrls = new List<Control>();

        public Form1()
        {
            InitializeComponent();

            comboWriteSize.Items.Add("1");
            var size = 512;
            for (int i = 0; i < 14; i++)
            {
                comboWriteSize.Items.Add(size.ToString());
                size <<= 1;
            }
            comboWriteSize.SelectedIndex = 1;
        }

        private void rdoSize_CheckedChanged(object sender, EventArgs e)
        {
            var rdoSize = grpBoxSize.Controls.OfType<RadioButton>().Single(elem => elem.Checked);
            writeSize = (ulong) (numSize.Value * ((int)rdoSize.Tag));
            txtByteSize.Text = writeSize.ToString();
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            var ret = fbd.ShowDialog();

            if (ret == DialogResult.Cancel)
            {
                return;
            }

            txtWritePath.Text = fbd.SelectedPath;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtWritePath.Text)  == false)
            {
                MessageBox.Show("指定ディレクトリが存在しません:[" +  txtWritePath.Text + "]");
                return;
            }

            var tmpFilePath = Path.Combine(txtWritePath.Text, Path.GetFileName(Path.GetTempFileName()));
            lblOpenFilePath.Text = tmpFilePath;

            try
            {
                if (File.Exists(tmpFilePath))
                {
                    MessageBox.Show("同名のファイルが存在します:[" + tmpFilePath + "]");
                }

                FileOptions fop = FileOptions.None;
                bool IsDelOnClose = chkDelOnClose.Checked;
                fop = IsDelOnClose ? fop | FileOptions.DeleteOnClose : fop;
                bool IsWriteThrough = chkWriteThrough.Checked;
                fop = IsWriteThrough ? fop | FileOptions.WriteThrough : fop;
                tmpFile = new FileStream(tmpFilePath, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.Read, 1024 * 1024, fop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("エラーが発生しました:" + ex.Message);
                return;
            }

            CtrlChange();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (tmpFile == null)
            {
                return;
            }

            tmpFile.Close();
            tmpFile.Dispose();
            tmpFile = null;
            
            lblOpenFilePath.Text = "";

            CtrlChange();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (writeTask != null)
            {
                Debug.WriteLine("write cancel");
                cancelTokenSource.Cancel();
                return;
            }

            if (tmpFile == null)
            {
                Debug.WriteLine("not open tmpfile");
                return;
            }

            if (writeSize == 0)
            {
                MessageBox.Show("書き込みサイズが0byteです。");
                return;
            }

            cancelTokenSource = new CancellationTokenSource();
            CancellationToken cancelToken = cancelTokenSource.Token;

            btnWrite.Text = "CANCEL";
            btnClose.Enabled = false;

            if (chkUseSeek.Checked == true)
            {
                tmpFile.Seek(0, SeekOrigin.Begin);
            }

            ulong blockSize = ulong.Parse(comboWriteSize.SelectedItem.ToString());
            var rdoBuff = grpBoxWriteOption.Controls.OfType<RadioButton>().Single(elem => elem.Checked);
            bool IsRand = (rdoBuff == rdoBuffRand);
            bool RandPerBlock = chkRandPerBlock.Checked;
            bool SameValueInBlock = chkSameValInBlock.Checked;

            string msg = string.Format("Sizez:{0} BlockSize:{1} Rand:{2} RandPerBlock:{3}", writeSize, blockSize, IsRand, RandPerBlock);
            txtLog.AppendText(msg + "\n");

            writeTask = new Task(() =>
            {
                ulong remain = (ulong) writeSize;
                int buffLen = (int) (remain < blockSize ? remain : blockSize);
                byte[] buff;
                createBuff(out buff, buffLen, IsRand, SameValueInBlock);

                while (remain > 0)
                {
                    if (cancelToken.IsCancellationRequested)
                    {
                        return;
                    }

                    buffLen = (int) (remain < blockSize ? remain : blockSize);
                    if (IsRand == true && RandPerBlock == true)
                    {
                        createBuff(out buff, buffLen, IsRand, SameValueInBlock);
                    }
                    
                    tmpFile.Write(buff, 0, buffLen);
                    remain -= (ulong) buffLen;
                }
            }, cancelToken);

            writeTask.ContinueWith(afterWrite);

            writeTask.Start();
        }



        private void createBuff(out byte[] buff,  int buffSize, bool IsRand, bool sameVal)
        {
            buff = new byte[buffSize];

            if (IsRand == false)
            {
                return;
            }

            if (sameVal == true)
            {
                byte val = lastVal;
                while (val == lastVal)
                {
                    val = (byte)rand.Next(255);
                }
                lastVal = val;

                for (int i=0; i<buffSize; i++)
                {
                    buff[i] = val;
                }
            }
            else
            {
                rand.NextBytes(buff);
            }

            return;
        }

        private void afterWrite(Task task)
        {
            writeTask = null;
            tmpFile.Flush();
            
            Invoke(new Action(() => btnWrite.Text = "WRITE"));
            Invoke(new Action(() => btnClose.Enabled = true));
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            if (tmpFile == null)
            {
                Debug.WriteLine("not open tmpfile");
                return;
            }

            tmpFile.Flush();
        }

        private void CtrlChange()
        {
            foreach (var ctrlObj in Controls)
            {
                Control ctrl = (Control)ctrlObj;
                ctrl.Enabled = ctrl.Enabled ? false : true;
            }
        }

        private void rdoBuffRandChkbox_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoSender = (RadioButton)sender;
            bool enableChkBlockPerRand = (rdoSender == rdoBuffRand);
            chkRandPerBlock.Enabled = enableChkBlockPerRand;
        }
    }
}
