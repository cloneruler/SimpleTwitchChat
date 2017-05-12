using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SimpleTwitchChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Navigate to the chat & bring the web browser foward
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "Twitch Username")
            {
                MessageBox.Show("Please enter a username!");
            }
            else
            {
                webBrowser1.Navigate("https://www.twitch.tv/" + textBox1.Text + "/chat?popout=");
                webBrowser1.BringToFront();
                webBrowser1.Show();
            }

        }

        //About MessageBox
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple program to open a popped out Twitch chat easily.\r This is a work in progress.");
        }

        //Close Chat
        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Hide();
            webBrowser1.SendToBack();
        }

        //Close the program (Close > Program)
        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Suppress the script errors 
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        //Open with chrome button
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "Twitch Username")
            {
                MessageBox.Show("Please enter a username!");
            }
            else
            {
                Process chrome = new Process();
               chrome.StartInfo.FileName = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
               chrome.StartInfo.Arguments = "https://www.twitch.tv/" + textBox1.Text + "/chat?popout=" + " --new-window";
               chrome.Start();
            }
        }
    }
}
