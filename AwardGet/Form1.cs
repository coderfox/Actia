using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace AwardGet
{
    public partial class showForm : Form
    {
        string strConfigFile = "";
        List<string> words = new List<string>();
        int interval = 0;
        bool state = false;
        int id = 0;
        public showForm()
        {
            InitializeComponent();
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            if (state == true)
            {
                iTimer.Enabled = false;
                state = false;
                controlButton.Text = "开始";
            }
            else
            {
                iTimer.Enabled = true;
                state = true;
                controlButton.Text = "停止";
            }
            
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            strConfigFile = openFileDialog1.FileName;
            INIClass r = new INIClass(strConfigFile);
            int intWordCount = 0;
            intWordCount = Convert.ToInt32(r.IniReadValue("general", "wordcount"));
            for (int i = 0; i < intWordCount; i++)
            {
                words.Add(r.IniReadValue("words", Convert.ToString(i)));
            }
            iTimer.Interval = Convert.ToInt32(r.IniReadValue("general", "interval"));
            textLabel.Font = new Font("微软雅黑", (float)Convert.ToInt32(r.IniReadValue("general", "fontsize")));
            MessageBox.Show("CFG RD FISED");
        }

        private void iTimer_Tick(object sender, EventArgs e)
        {
            textLabel.Text = words[id];
            id++;
            if (id == words.Count)
            {
                id = 0;
            }
        }

        private void configEditorButton_Click(object sender, EventArgs e)
        {

        }
    }
}
