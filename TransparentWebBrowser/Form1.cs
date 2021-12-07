using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using MetroSet_UI.Controls;

namespace TransparentWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //AcceptButton = metroSetButton_search;
            InitializeComponent();
            InitializeChromeBrowser();
            LoadINIFile();
            metroSetLabel1.Text = this.Text;
            this.trackBar1.Value = (int)(this.Opacity * 100); 
            this.TopMost = true;
        }

        const string INI_PATH = ".\\bookmarks.ini";

        private void LoadINIFile()
        {
            IniFile ini = new IniFile();
            try
            {
                ini.Load(INI_PATH);
                string[] bookmarkNames = { "(비어있음)", "(비어있음)", "(비어있음)", "(비어있음)", "(비어있음)" } ;
                
                for (int i = 0; i < ini.Keys.Count; i++)
                {
                    bookmarks.Add(ini["Bookmark" + i]["Name"].Value, ini["Bookmark" + i]["URL"].Value);
                    bookmarkNames[i] = ini["Bookmark" + i]["Name"].Value;
                }
                int j = 0; 
                foreach (MetroSetButton btn in panel3.Controls.OfType<MetroSetButton>().Reverse())
                {
                    btn.Text = bookmarkNames[j++];
                    if (btn.Text == "(비어있음)")
                    {
                        btn.NormalColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
                        btn.NormalTextColor = Color.Gray;
                    }
                }
                foreach(var items in bookmarks)
                {
                    chromiumWebBrowser1.Load(items.Value);
                    return;
                }

            }
            catch
            {
                ini.Save(INI_PATH);
                chromiumWebBrowser1.Load("https://www.google.com");
            }
        }

        private void SaveINIFile()
        {
            IniFile ini = new IniFile();
            int i = 0;
            foreach(var item in bookmarks)
            {
                ini["Bookmark" + i]["Name"] = item.Key;
                ini["Bookmark" + i++]["URL"] = item.Value;
            }
            ini.Save(INI_PATH);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load(metroSetTextBox_url.Text);
            
        }

        private void InitializeChromeBrowser()
        {
            CefSettings cefSettings = new CefSettings();
            Cef.Initialize(cefSettings);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = (double)trackBar1.Value / 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Stop();
            this.Close();
        }

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

        private void chromiumWebBrowser1_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.metroSetTextBox_url.Text = e.Address;
            
        }


        public static string abName;
        public static Dictionary<string, string> bookmarks = new Dictionary<string, string>();


        private void addBookmark(MetroSetButton btn, ChromiumWebBrowser chwb)
        {
            AddBookmark ab = new AddBookmark(btn, chwb);
            ab.ShowDialog();
            if (ab.DialogResult == DialogResult.OK)
            {
                btn.Text = abName;
                btn.NormalColor = System.Drawing.Color.FromArgb(65, 177, 225);
                btn.NormalTextColor = Color.White;
            }
                
            else if (ab.DialogResult == DialogResult.No)
            {
                btn.Text = "(비어있음)";
                btn.NormalColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
                btn.NormalTextColor = Color.Gray;
            }
            SaveINIFile();
        }
        
        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(300, 400);


            if (MessageBox.Show("왼쪽 위 꼭짓점에 마우스를 올려놓고 스페이스바를 누르세요", "좌표1 (x1,y1) 설정", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                point1 = Cursor.Position;
            }
            if (MessageBox.Show("오른쪽 아래 꼭짓점에 마우스를 올려놓고 스페이스바를 누르세요", "좌표2 (x2, y2) 설정", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                point2 = Cursor.Position;
            }
            this.Location = point1;

            int width = point2.X - point1.X;
            int height = point2.Y - point1.Y;

            if (width <= 400) // 최소 100
                width = 400;
            if (height <= 300) // 최소 100
                height = 300;
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(width, height);

        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            if (metroSetButton_showhide.Text == "숨기기")
            {
                panel2.Visible = false;
                panel3.Visible = false;
                metroSetButton_showhide.Text = "보이기";
            }
            else if (metroSetButton_showhide.Text == "보이기")
            {
                panel2.Visible = true;
                panel3.Visible = true;
                metroSetButton_showhide.Text = "숨기기";
            }
        }

        private void metroSetButton3_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Stop();
            this.Close();
        }

        private void metroSetButton_maximzie_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else if (this.WindowState == FormWindowState.Normal) 
                this.WindowState = FormWindowState.Maximized;
        }

        private void metroSetButton_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
        }

        private void metroSetButton_search_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load(metroSetTextBox_url.Text);
        }

        private void metroSetTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                metroSetButton_search_Click(sender, e);
        }

        private void metroSetButton_bookmark_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    try
                    {
                        this.chromiumWebBrowser1.Load(bookmarks[((MetroSetButton)sender).Text]);
                    }
                    catch
                    {
                        addBookmark((MetroSetButton)sender, chromiumWebBrowser1);
                    }
                    break;
                case MouseButtons.Right:
                    addBookmark((MetroSetButton)sender, chromiumWebBrowser1);
                    break;
            }
            ((MetroSetButton)sender).HoverBorderColor = ((MetroSetButton)sender).NormalBorderColor;
            ((MetroSetButton)sender).HoverColor = ((MetroSetButton)sender).NormalColor;
            ((MetroSetButton)sender).HoverTextColor = ((MetroSetButton)sender).NormalTextColor;
        }

        private void metroSetButton_bookmark_MouseMove(object sender, MouseEventArgs e)
        {
            ((MetroSetButton)sender).HoverBorderColor = Color.FromArgb(95, 207, 255);
            ((MetroSetButton)sender).HoverColor = Color.FromArgb(95, 207, 255);
            ((MetroSetButton)sender).HoverTextColor = Color.White;
        }

        private void metroSetLabel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void metroSetLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void metroSetButton1_Click_1(object sender, EventArgs e)
        {
            if (chromiumWebBrowser1.CanGoBack)
                chromiumWebBrowser1.Back();
        }

        private void metroSetButton2_Click_1(object sender, EventArgs e)
        {
            if (chromiumWebBrowser1.CanGoForward)
                chromiumWebBrowser1.Forward();
        }
    }
}
