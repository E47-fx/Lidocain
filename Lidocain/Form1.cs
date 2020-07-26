using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using System.Threading;

namespace Lidocain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static MP3Player play = new MP3Player(@"Sounds/wtf.mp3");

        public static void DownloadFile(string path, string fileName)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + WebMAN.IP + "/" + path);
            request.Credentials = new NetworkCredential("PPS3Client", "");
            request.Method = WebRequestMethods.Ftp.DownloadFile;

                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                {
                    if (ftpStream.CanRead)
                    {
                        if (ftpStream.CanWrite)
                        {
                            using (Stream fileStream = File.Create(fileName))
                            {
                                ftpStream.CopyTo(fileStream);
                            }
                        }
                        else MessageBox.Show("Could not write file into target directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Could not read file from the PS3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                //MessageBox.Show("Error while trying to retrieve file informations from the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cnnctbtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(ipbox.Text))
            {
                play.Load(play.mediaFile);
                play.Play();
                MessageBox.Show("Specify a fucking ip address", "bruh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                play.Dispose();
            }
            else if (ccapi.Checked)
            {
                status.Text = "Connecting to " + ipbox.Text + "...";
                if (WebMAN.ConnectTarget(ipbox.Text, WebMAN.Port.CCAPI))
                {
                    status.Text = "Connected to " + ipbox.Text;
                    WebMAN.RingBuzzer(0x4, 0x6);
                    WebMAN.Notify("E-47 PS3 Dumper has established an connection to this PS3.\n\n\n:3");
                }
                else status.Text = "Connection to " + ipbox.Text + " failed.";

            }
            else if(ps3mapi.Checked)
            {
               
                status.Text = "Connecting to " + ipbox.Text + "...";
                if (WebMAN.ConnectTarget(ipbox.Text, WebMAN.Port.PS3MAPI))
                {
                    status.Text = "Connected to " + ipbox.Text;
                    WebMAN.Notify("E-47 PS3 Dumper has established an connection to this PS3.\n\n\n:3");
                    WebMAN.RingBuzzer(0x4, 0x6);
                    if (WebMAN.isHEN())
                    {
                        HENbox hen = new HENbox();
                        hen.Show();
                    }
                }
                else status.Text = "Connection to " + ipbox.Text + " failed.";
            }
            else
            {
                play.Load(play.mediaFile);
                play.Play();
                MessageBox.Show("Select a fucking api", "bruh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                play.Dispose();
            }
            
        }

        private void dumplv1btn_Click(object sender, EventArgs e)
        {
            try
            {
                WebMAN.Dump(WebMAN.DumpFile.LV1);
                WebMAN.RenameFile("/dev_hdd0/dump_lv1.bin", "/dev_hdd0/lv1dump.bin");
                status.Text = "File Dumped!";
                Thread.Sleep(100);
                DownloadFile("dev_hdd0/lv1dump.bin", "lv1dump.bin");
                status.Text = "Dump retrieved!";
                if(rbt.Checked)
                {
                    string res = "";
                    if (sftrbt.Checked)
                        WebMAN.Power(WebMAN.PowerFlag.SoftReboot, out res);
                    else if(hrdrbt.Checked)
                        WebMAN.Power(WebMAN.PowerFlag.HardReboot, out res);
                    else if(qckrbt.Checked)
                        WebMAN.Power(WebMAN.PowerFlag.QuickReboot, out res);

                    status.Text = res;
                }
                else WebMAN.RingBuzzer(0xA, 0x1B6);
            }
            catch
            {
                status.Text = "Failed to dump LV1 memory";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WebMAN.DisconnectTarget() == 0)
                status.Text = "Disconnected from the target.";
            else status.Text = "Failed to disconnect from the target.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            play.Repeat = false;
            play.Load(play.mediaFile);
        }

        private void dumplv2btn_Click(object sender, EventArgs e)
        {
            try
            {
                WebMAN.Dump(WebMAN.DumpFile.LV2);
                WebMAN.RenameFile("/dev_hdd0/dump_lv2.bin", "/dev_hdd0/lv2dump.bin");
                Thread.Sleep(100);
                DownloadFile("dev_hdd0/lv2dump.bin", "lv2dump.bin");
                status.Text = "Dump retrieved!";

                if (rbt.Checked)
                {
                    string res = "";
                    if (sftrbt.Checked)
                        WebMAN.Power(WebMAN.PowerFlag.SoftReboot, out res);
                    else if (hrdrbt.Checked)
                        WebMAN.Power(WebMAN.PowerFlag.HardReboot, out res);
                    else if (qckrbt.Checked)
                        WebMAN.Power(WebMAN.PowerFlag.QuickReboot, out res);

                    status.Text = res;
                }
                else WebMAN.RingBuzzer(0xA, 0x1B6);
            }
            catch
            {
                status.Text = "Failed to dump LV2 memory";
            }
        }

        private void dumprsxbtn_Click(object sender, EventArgs e)
        {
            try
            {
                WebMAN.Dump(WebMAN.DumpFile.RSX);
                WebMAN.RenameFile("/dev_hdd0/dump_rsx.bin", "/dev_hdd0/RSXdump.bin");
                Thread.Sleep(100);
                DownloadFile("dev_hdd0/RSXdump.bin", "RSXdump.bin");
                status.Text = "Dump retrieved!";

                if (rbt.Checked)
                {
                    string res = "";
                    if (sftrbt.Checked)
                        WebMAN.Power(WebMAN.PowerFlag.SoftReboot, out res);
                    else if (hrdrbt.Checked)
                        WebMAN.Power(WebMAN.PowerFlag.HardReboot, out res);
                    else if (qckrbt.Checked)
                        WebMAN.Power(WebMAN.PowerFlag.QuickReboot, out res);

                    status.Text = res;
                }
                else WebMAN.RingBuzzer(0xA, 0x1B6);
            }
            catch
            {
                status.Text = "Failed to dump RSX memory";
            }
        }

        private void dumpcstsize_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not supported at the moment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //dumpsize f = new dumpsize();
            //f.Show();
        }

        private void dumpmemfull_Click(object sender, EventArgs e)
        {
            try
            {
                WebMAN.Dump(WebMAN.DumpFile.FullMemory);
                WebMAN.RenameFile("/dev_hdd0/dump_full.bin", "/dev_hdd0/FULLdump.bin");
                Thread.Sleep(100);
                DownloadFile("dev_hdd0/FULLdump.bin", "FULLdump.bin");
                status.Text = "Dump retrieved!";

                if (rbt.Checked)
                {
                    string res = "";

                    if (sftrbt.Checked)
                        WebMAN.Power(WebMAN.PowerFlag.SoftReboot, out res);
                    else if (hrdrbt.Checked)
                        WebMAN.Power(WebMAN.PowerFlag.HardReboot, out res);
                    else if (qckrbt.Checked)
                        WebMAN.Power(WebMAN.PowerFlag.QuickReboot, out res);

                    status.Text = res;
                }
                else WebMAN.RingBuzzer(0xA, 0x1B6);
            }
            catch
            {
                status.Text = "Failed to dump full memory";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
