using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using MetroSet_UI.Controls;

namespace TransparentWebBrowser
{
    public partial class AddBookmark : Form
    {
        public AddBookmark()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            AcceptButton = button1;
            CancelButton = button2;
            this.TopMost = true;
        }
        public AddBookmark(MetroSetButton btn, ChromiumWebBrowser chwb)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            AcceptButton = button1;
            CancelButton = button2;
            this.TopMost = true;
            if (Form1.bookmarks.ContainsKey(btn.Text))
            {
                isModify = true;
                label3.Text = "북마크 수정";
                prevName = btn.Text;
                textBox1.Text = btn.Text;
                textBox2.Text = Form1.bookmarks[btn.Text];
                button3.Enabled = true;
            }
            else
            {
                isModify = false;
                label3.Text = "북마크 추가";
                textBox2.Text = chwb.Address;
                button3.Enabled = false;
            }
                
        }

        static bool isModify;
        static string prevName;
        static Point mousePoint = new Point(0, 0);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isModify)
                Form1.bookmarks.Remove(prevName); // 기존 이름을 삭제하고
            Form1.bookmarks.Add(textBox1.Text, textBox2.Text); // 새 이름으로 추가
            Form1.abName = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.bookmarks.Remove(prevName);
            DialogResult = DialogResult.No;
        }
    }
}
