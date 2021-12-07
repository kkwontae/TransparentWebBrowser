
namespace TransparentWebBrowser
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetButton_minimize = new MetroSet_UI.Controls.MetroSetButton();
            this.panel1_padding2 = new System.Windows.Forms.Panel();
            this.metroSetButton_maximzie = new MetroSet_UI.Controls.MetroSetButton();
            this.panel1_padding3 = new System.Windows.Forms.Panel();
            this.metroSetButton_exit = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton_showhide = new MetroSet_UI.Controls.MetroSetButton();
            this.panel1_padding1 = new System.Windows.Forms.Panel();
            this.metroSetButton_sizecontrol = new MetroSet_UI.Controls.MetroSetButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroSetButton_search = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetTextBox_url = new MetroSet_UI.Controls.MetroSetTextBox();
            this.panel2_padding2 = new System.Windows.Forms.Panel();
            this.metroSetButton_forward = new MetroSet_UI.Controls.MetroSetButton();
            this.panel2_padding1 = new System.Windows.Forms.Panel();
            this.metroSetButton_back = new MetroSet_UI.Controls.MetroSetButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroSetButton_bookmark5 = new MetroSet_UI.Controls.MetroSetButton();
            this.panel_padding4 = new System.Windows.Forms.Panel();
            this.metroSetButton_bookmark4 = new MetroSet_UI.Controls.MetroSetButton();
            this.panel_padding3 = new System.Windows.Forms.Panel();
            this.metroSetButton_bookmark3 = new MetroSet_UI.Controls.MetroSetButton();
            this.panel_padding2 = new System.Windows.Forms.Panel();
            this.metroSetButton_bookmark2 = new MetroSet_UI.Controls.MetroSetButton();
            this.panel_padding1 = new System.Windows.Forms.Panel();
            this.metroSetButton_bookmark1 = new MetroSet_UI.Controls.MetroSetButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
// TODO: '기본 형식이 잘못되었습니다. System.IntPtr. CodeObjectCreateExpression을 사용하십시오.' 예외가 발생하여 ''의 코드를 생성하지 못했습니다.
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 84);
            this.chromiumWebBrowser1.Margin = new System.Windows.Forms.Padding(2);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(625, 263);
            this.chromiumWebBrowser1.TabIndex = 3;
            this.chromiumWebBrowser1.AddressChanged += new System.EventHandler<CefSharp.AddressChangedEventArgs>(this.chromiumWebBrowser1_AddressChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.trackBar1.Location = new System.Drawing.Point(538, 3);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(84, 22);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickFrequency = 25;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.metroSetLabel1);
            this.panel1.Controls.Add(this.metroSetButton_minimize);
            this.panel1.Controls.Add(this.panel1_padding2);
            this.panel1.Controls.Add(this.metroSetButton_maximzie);
            this.panel1.Controls.Add(this.panel1_padding3);
            this.panel1.Controls.Add(this.metroSetButton_exit);
            this.panel1.Controls.Add(this.metroSetButton_showhide);
            this.panel1.Controls.Add(this.panel1_padding1);
            this.panel1.Controls.Add(this.metroSetButton_sizecontrol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(625, 28);
            this.panel1.TabIndex = 6;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(156, 3);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(385, 22);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 16;
            this.metroSetLabel1.Text = "투명브라우저 (Chrome) ";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            this.metroSetLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroSetLabel1_MouseDown);
            this.metroSetLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroSetLabel1_MouseMove);
            // 
            // metroSetButton_minimize
            // 
            this.metroSetButton_minimize.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_minimize.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_minimize.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroSetButton_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton_minimize.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_minimize.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_minimize.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_minimize.IsDerivedStyle = true;
            this.metroSetButton_minimize.Location = new System.Drawing.Point(541, 3);
            this.metroSetButton_minimize.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetButton_minimize.Name = "metroSetButton_minimize";
            this.metroSetButton_minimize.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_minimize.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_minimize.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_minimize.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_minimize.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_minimize.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_minimize.Size = new System.Drawing.Size(25, 22);
            this.metroSetButton_minimize.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton_minimize.StyleManager = null;
            this.metroSetButton_minimize.TabIndex = 15;
            this.metroSetButton_minimize.TabStop = false;
            this.metroSetButton_minimize.Text = "_";
            this.metroSetButton_minimize.ThemeAuthor = "Narwin";
            this.metroSetButton_minimize.ThemeName = "MetroLite";
            this.metroSetButton_minimize.Click += new System.EventHandler(this.metroSetButton_minimize_Click);
            // 
            // panel1_padding2
            // 
            this.panel1_padding2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1_padding2.Location = new System.Drawing.Point(566, 3);
            this.panel1_padding2.Margin = new System.Windows.Forms.Padding(2);
            this.panel1_padding2.Name = "panel1_padding2";
            this.panel1_padding2.Size = new System.Drawing.Size(3, 22);
            this.panel1_padding2.TabIndex = 13;
            // 
            // metroSetButton_maximzie
            // 
            this.metroSetButton_maximzie.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_maximzie.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_maximzie.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_maximzie.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroSetButton_maximzie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton_maximzie.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_maximzie.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_maximzie.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_maximzie.IsDerivedStyle = true;
            this.metroSetButton_maximzie.Location = new System.Drawing.Point(569, 3);
            this.metroSetButton_maximzie.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetButton_maximzie.Name = "metroSetButton_maximzie";
            this.metroSetButton_maximzie.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_maximzie.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_maximzie.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_maximzie.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_maximzie.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_maximzie.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_maximzie.Size = new System.Drawing.Size(25, 22);
            this.metroSetButton_maximzie.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton_maximzie.StyleManager = null;
            this.metroSetButton_maximzie.TabIndex = 14;
            this.metroSetButton_maximzie.TabStop = false;
            this.metroSetButton_maximzie.Text = "□";
            this.metroSetButton_maximzie.ThemeAuthor = "Narwin";
            this.metroSetButton_maximzie.ThemeName = "MetroLite";
            this.metroSetButton_maximzie.Click += new System.EventHandler(this.metroSetButton_maximzie_Click);
            // 
            // panel1_padding3
            // 
            this.panel1_padding3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1_padding3.Location = new System.Drawing.Point(594, 3);
            this.panel1_padding3.Margin = new System.Windows.Forms.Padding(2);
            this.panel1_padding3.Name = "panel1_padding3";
            this.panel1_padding3.Size = new System.Drawing.Size(3, 22);
            this.panel1_padding3.TabIndex = 12;
            // 
            // metroSetButton_exit
            // 
            this.metroSetButton_exit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_exit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_exit.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroSetButton_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton_exit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_exit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_exit.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_exit.IsDerivedStyle = true;
            this.metroSetButton_exit.Location = new System.Drawing.Point(597, 3);
            this.metroSetButton_exit.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetButton_exit.Name = "metroSetButton_exit";
            this.metroSetButton_exit.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_exit.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_exit.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_exit.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_exit.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_exit.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_exit.Size = new System.Drawing.Size(25, 22);
            this.metroSetButton_exit.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton_exit.StyleManager = null;
            this.metroSetButton_exit.TabIndex = 9;
            this.metroSetButton_exit.TabStop = false;
            this.metroSetButton_exit.Text = "x";
            this.metroSetButton_exit.ThemeAuthor = "Narwin";
            this.metroSetButton_exit.ThemeName = "MetroLite";
            this.metroSetButton_exit.Click += new System.EventHandler(this.metroSetButton3_Click);
            // 
            // metroSetButton_showhide
            // 
            this.metroSetButton_showhide.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_showhide.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_showhide.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_showhide.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetButton_showhide.Font = new System.Drawing.Font("굴림", 9F);
            this.metroSetButton_showhide.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_showhide.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_showhide.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_showhide.IsDerivedStyle = true;
            this.metroSetButton_showhide.Location = new System.Drawing.Point(81, 3);
            this.metroSetButton_showhide.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetButton_showhide.Name = "metroSetButton_showhide";
            this.metroSetButton_showhide.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_showhide.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_showhide.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_showhide.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_showhide.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_showhide.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_showhide.Size = new System.Drawing.Size(75, 22);
            this.metroSetButton_showhide.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton_showhide.StyleManager = null;
            this.metroSetButton_showhide.TabIndex = 11;
            this.metroSetButton_showhide.TabStop = false;
            this.metroSetButton_showhide.Text = "숨기기";
            this.metroSetButton_showhide.ThemeAuthor = "Narwin";
            this.metroSetButton_showhide.ThemeName = "MetroLite";
            this.metroSetButton_showhide.Click += new System.EventHandler(this.metroSetButton2_Click);
            // 
            // panel1_padding1
            // 
            this.panel1_padding1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1_padding1.Location = new System.Drawing.Point(78, 3);
            this.panel1_padding1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1_padding1.Name = "panel1_padding1";
            this.panel1_padding1.Size = new System.Drawing.Size(3, 22);
            this.panel1_padding1.TabIndex = 9;
            // 
            // metroSetButton_sizecontrol
            // 
            this.metroSetButton_sizecontrol.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_sizecontrol.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_sizecontrol.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_sizecontrol.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetButton_sizecontrol.Font = new System.Drawing.Font("굴림", 9F);
            this.metroSetButton_sizecontrol.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_sizecontrol.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_sizecontrol.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_sizecontrol.IsDerivedStyle = true;
            this.metroSetButton_sizecontrol.Location = new System.Drawing.Point(3, 3);
            this.metroSetButton_sizecontrol.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetButton_sizecontrol.Name = "metroSetButton_sizecontrol";
            this.metroSetButton_sizecontrol.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_sizecontrol.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_sizecontrol.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_sizecontrol.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_sizecontrol.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_sizecontrol.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_sizecontrol.Size = new System.Drawing.Size(75, 22);
            this.metroSetButton_sizecontrol.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton_sizecontrol.StyleManager = null;
            this.metroSetButton_sizecontrol.TabIndex = 9;
            this.metroSetButton_sizecontrol.TabStop = false;
            this.metroSetButton_sizecontrol.Text = "크기 조정";
            this.metroSetButton_sizecontrol.ThemeAuthor = "Narwin";
            this.metroSetButton_sizecontrol.ThemeName = "MetroLite";
            this.metroSetButton_sizecontrol.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.metroSetButton_search);
            this.panel2.Controls.Add(this.metroSetTextBox_url);
            this.panel2.Controls.Add(this.panel2_padding2);
            this.panel2.Controls.Add(this.metroSetButton_forward);
            this.panel2.Controls.Add(this.panel2_padding1);
            this.panel2.Controls.Add(this.metroSetButton_back);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(625, 28);
            this.panel2.TabIndex = 7;
            // 
            // metroSetButton_search
            // 
            this.metroSetButton_search.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_search.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_search.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroSetButton_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton_search.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_search.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_search.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_search.IsDerivedStyle = true;
            this.metroSetButton_search.Location = new System.Drawing.Point(480, 3);
            this.metroSetButton_search.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetButton_search.Name = "metroSetButton_search";
            this.metroSetButton_search.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_search.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_search.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_search.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_search.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_search.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_search.Size = new System.Drawing.Size(58, 22);
            this.metroSetButton_search.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton_search.StyleManager = null;
            this.metroSetButton_search.TabIndex = 9;
            this.metroSetButton_search.TabStop = false;
            this.metroSetButton_search.Text = "이동";
            this.metroSetButton_search.ThemeAuthor = "Narwin";
            this.metroSetButton_search.ThemeName = "MetroLite";
            this.metroSetButton_search.Click += new System.EventHandler(this.metroSetButton_search_Click);
            // 
            // metroSetTextBox_url
            // 
            this.metroSetTextBox_url.AutoCompleteCustomSource = null;
            this.metroSetTextBox_url.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox_url.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox_url.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox_url.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTextBox_url.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox_url.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTextBox_url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetTextBox_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox_url.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetTextBox_url.Image = null;
            this.metroSetTextBox_url.IsDerivedStyle = true;
            this.metroSetTextBox_url.Lines = null;
            this.metroSetTextBox_url.Location = new System.Drawing.Point(59, 3);
            this.metroSetTextBox_url.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetTextBox_url.MaxLength = 32767;
            this.metroSetTextBox_url.Multiline = false;
            this.metroSetTextBox_url.Name = "metroSetTextBox_url";
            this.metroSetTextBox_url.ReadOnly = false;
            this.metroSetTextBox_url.Size = new System.Drawing.Size(479, 22);
            this.metroSetTextBox_url.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTextBox_url.StyleManager = null;
            this.metroSetTextBox_url.TabIndex = 9;
            this.metroSetTextBox_url.Text = "https://www.google.com";
            this.metroSetTextBox_url.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox_url.ThemeAuthor = "Narwin";
            this.metroSetTextBox_url.ThemeName = "MetroLite";
            this.metroSetTextBox_url.UseSystemPasswordChar = false;
            this.metroSetTextBox_url.WatermarkText = "";
            this.metroSetTextBox_url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroSetTextBox1_KeyDown);
            // 
            // panel2_padding2
            // 
            this.panel2_padding2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2_padding2.Location = new System.Drawing.Point(56, 3);
            this.panel2_padding2.Name = "panel2_padding2";
            this.panel2_padding2.Size = new System.Drawing.Size(3, 22);
            this.panel2_padding2.TabIndex = 11;
            // 
            // metroSetButton_forward
            // 
            this.metroSetButton_forward.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_forward.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_forward.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_forward.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetButton_forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton_forward.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_forward.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_forward.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_forward.IsDerivedStyle = true;
            this.metroSetButton_forward.Location = new System.Drawing.Point(31, 3);
            this.metroSetButton_forward.Name = "metroSetButton_forward";
            this.metroSetButton_forward.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_forward.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_forward.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_forward.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_forward.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_forward.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_forward.Size = new System.Drawing.Size(25, 22);
            this.metroSetButton_forward.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton_forward.StyleManager = null;
            this.metroSetButton_forward.TabIndex = 10;
            this.metroSetButton_forward.Text = ">";
            this.metroSetButton_forward.ThemeAuthor = "Narwin";
            this.metroSetButton_forward.ThemeName = "MetroLite";
            this.metroSetButton_forward.Click += new System.EventHandler(this.metroSetButton2_Click_1);
            // 
            // panel2_padding1
            // 
            this.panel2_padding1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2_padding1.Location = new System.Drawing.Point(28, 3);
            this.panel2_padding1.Name = "panel2_padding1";
            this.panel2_padding1.Size = new System.Drawing.Size(3, 22);
            this.panel2_padding1.TabIndex = 9;
            // 
            // metroSetButton_back
            // 
            this.metroSetButton_back.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_back.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_back.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_back.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetButton_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton_back.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_back.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_back.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_back.IsDerivedStyle = true;
            this.metroSetButton_back.Location = new System.Drawing.Point(3, 3);
            this.metroSetButton_back.Name = "metroSetButton_back";
            this.metroSetButton_back.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_back.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_back.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_back.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_back.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_back.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_back.Size = new System.Drawing.Size(25, 22);
            this.metroSetButton_back.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton_back.StyleManager = null;
            this.metroSetButton_back.TabIndex = 9;
            this.metroSetButton_back.Text = "<";
            this.metroSetButton_back.ThemeAuthor = "Narwin";
            this.metroSetButton_back.ThemeName = "MetroLite";
            this.metroSetButton_back.Click += new System.EventHandler(this.metroSetButton1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.metroSetButton_bookmark5);
            this.panel3.Controls.Add(this.panel_padding4);
            this.panel3.Controls.Add(this.metroSetButton_bookmark4);
            this.panel3.Controls.Add(this.panel_padding3);
            this.panel3.Controls.Add(this.metroSetButton_bookmark3);
            this.panel3.Controls.Add(this.panel_padding2);
            this.panel3.Controls.Add(this.metroSetButton_bookmark2);
            this.panel3.Controls.Add(this.panel_padding1);
            this.panel3.Controls.Add(this.metroSetButton_bookmark1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(625, 28);
            this.panel3.TabIndex = 8;
            // 
            // metroSetButton_bookmark5
            // 
            this.metroSetButton_bookmark5.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark5.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark5.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_bookmark5.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetButton_bookmark5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.metroSetButton_bookmark5.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_bookmark5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_bookmark5.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_bookmark5.IsDerivedStyle = true;
            this.metroSetButton_bookmark5.Location = new System.Drawing.Point(375, 3);
            this.metroSetButton_bookmark5.Margin = new System.Windows.Forms.Padding(5);
            this.metroSetButton_bookmark5.Name = "metroSetButton_bookmark5";
            this.metroSetButton_bookmark5.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark5.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark5.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_bookmark5.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_bookmark5.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_bookmark5.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_bookmark5.Size = new System.Drawing.Size(90, 22);
            this.metroSetButton_bookmark5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton_bookmark5.StyleManager = null;
            this.metroSetButton_bookmark5.TabIndex = 13;
            this.metroSetButton_bookmark5.TabStop = false;
            this.metroSetButton_bookmark5.Text = "(비어있음)";
            this.metroSetButton_bookmark5.ThemeAuthor = "Narwin";
            this.metroSetButton_bookmark5.ThemeName = "MetroLite";
            this.metroSetButton_bookmark5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroSetButton_bookmark_MouseClick);
            this.metroSetButton_bookmark5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroSetButton_bookmark_MouseMove);
            // 
            // panel_padding4
            // 
            this.panel_padding4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_padding4.Location = new System.Drawing.Point(372, 3);
            this.panel_padding4.Margin = new System.Windows.Forms.Padding(2);
            this.panel_padding4.Name = "panel_padding4";
            this.panel_padding4.Size = new System.Drawing.Size(3, 22);
            this.panel_padding4.TabIndex = 22;
            // 
            // metroSetButton_bookmark4
            // 
            this.metroSetButton_bookmark4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark4.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_bookmark4.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetButton_bookmark4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.metroSetButton_bookmark4.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_bookmark4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_bookmark4.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_bookmark4.IsDerivedStyle = true;
            this.metroSetButton_bookmark4.Location = new System.Drawing.Point(282, 3);
            this.metroSetButton_bookmark4.Margin = new System.Windows.Forms.Padding(5);
            this.metroSetButton_bookmark4.Name = "metroSetButton_bookmark4";
            this.metroSetButton_bookmark4.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark4.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark4.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_bookmark4.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_bookmark4.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_bookmark4.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_bookmark4.Size = new System.Drawing.Size(90, 22);
            this.metroSetButton_bookmark4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton_bookmark4.StyleManager = null;
            this.metroSetButton_bookmark4.TabIndex = 12;
            this.metroSetButton_bookmark4.TabStop = false;
            this.metroSetButton_bookmark4.Text = "(비어있음)";
            this.metroSetButton_bookmark4.ThemeAuthor = "Narwin";
            this.metroSetButton_bookmark4.ThemeName = "MetroLite";
            this.metroSetButton_bookmark4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroSetButton_bookmark_MouseClick);
            this.metroSetButton_bookmark4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroSetButton_bookmark_MouseMove);
            // 
            // panel_padding3
            // 
            this.panel_padding3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_padding3.Location = new System.Drawing.Point(279, 3);
            this.panel_padding3.Margin = new System.Windows.Forms.Padding(2);
            this.panel_padding3.Name = "panel_padding3";
            this.panel_padding3.Size = new System.Drawing.Size(3, 22);
            this.panel_padding3.TabIndex = 21;
            // 
            // metroSetButton_bookmark3
            // 
            this.metroSetButton_bookmark3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark3.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_bookmark3.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetButton_bookmark3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.metroSetButton_bookmark3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_bookmark3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_bookmark3.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_bookmark3.IsDerivedStyle = true;
            this.metroSetButton_bookmark3.Location = new System.Drawing.Point(189, 3);
            this.metroSetButton_bookmark3.Margin = new System.Windows.Forms.Padding(5);
            this.metroSetButton_bookmark3.Name = "metroSetButton_bookmark3";
            this.metroSetButton_bookmark3.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark3.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark3.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_bookmark3.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_bookmark3.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_bookmark3.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_bookmark3.Size = new System.Drawing.Size(90, 22);
            this.metroSetButton_bookmark3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton_bookmark3.StyleManager = null;
            this.metroSetButton_bookmark3.TabIndex = 11;
            this.metroSetButton_bookmark3.TabStop = false;
            this.metroSetButton_bookmark3.Text = "(비어있음)";
            this.metroSetButton_bookmark3.ThemeAuthor = "Narwin";
            this.metroSetButton_bookmark3.ThemeName = "MetroLite";
            this.metroSetButton_bookmark3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroSetButton_bookmark_MouseClick);
            this.metroSetButton_bookmark3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroSetButton_bookmark_MouseMove);
            // 
            // panel_padding2
            // 
            this.panel_padding2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_padding2.Location = new System.Drawing.Point(186, 3);
            this.panel_padding2.Margin = new System.Windows.Forms.Padding(2);
            this.panel_padding2.Name = "panel_padding2";
            this.panel_padding2.Size = new System.Drawing.Size(3, 22);
            this.panel_padding2.TabIndex = 20;
            // 
            // metroSetButton_bookmark2
            // 
            this.metroSetButton_bookmark2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark2.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_bookmark2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetButton_bookmark2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.metroSetButton_bookmark2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_bookmark2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_bookmark2.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_bookmark2.IsDerivedStyle = true;
            this.metroSetButton_bookmark2.Location = new System.Drawing.Point(96, 3);
            this.metroSetButton_bookmark2.Margin = new System.Windows.Forms.Padding(5);
            this.metroSetButton_bookmark2.Name = "metroSetButton_bookmark2";
            this.metroSetButton_bookmark2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark2.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_bookmark2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_bookmark2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_bookmark2.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_bookmark2.Size = new System.Drawing.Size(90, 22);
            this.metroSetButton_bookmark2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton_bookmark2.StyleManager = null;
            this.metroSetButton_bookmark2.TabIndex = 10;
            this.metroSetButton_bookmark2.TabStop = false;
            this.metroSetButton_bookmark2.Text = "(비어있음)";
            this.metroSetButton_bookmark2.ThemeAuthor = "Narwin";
            this.metroSetButton_bookmark2.ThemeName = "MetroLite";
            this.metroSetButton_bookmark2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroSetButton_bookmark_MouseClick);
            this.metroSetButton_bookmark2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroSetButton_bookmark_MouseMove);
            // 
            // panel_padding1
            // 
            this.panel_padding1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_padding1.Location = new System.Drawing.Point(93, 3);
            this.panel_padding1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_padding1.Name = "panel_padding1";
            this.panel_padding1.Size = new System.Drawing.Size(3, 22);
            this.panel_padding1.TabIndex = 19;
            // 
            // metroSetButton_bookmark1
            // 
            this.metroSetButton_bookmark1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_bookmark1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetButton_bookmark1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.metroSetButton_bookmark1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_bookmark1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_bookmark1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_bookmark1.IsDerivedStyle = true;
            this.metroSetButton_bookmark1.Location = new System.Drawing.Point(3, 3);
            this.metroSetButton_bookmark1.Margin = new System.Windows.Forms.Padding(5);
            this.metroSetButton_bookmark1.Name = "metroSetButton_bookmark1";
            this.metroSetButton_bookmark1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_bookmark1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_bookmark1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_bookmark1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_bookmark1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_bookmark1.Size = new System.Drawing.Size(90, 22);
            this.metroSetButton_bookmark1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton_bookmark1.StyleManager = null;
            this.metroSetButton_bookmark1.TabIndex = 9;
            this.metroSetButton_bookmark1.TabStop = false;
            this.metroSetButton_bookmark1.Text = "(비어있음)";
            this.metroSetButton_bookmark1.ThemeAuthor = "Narwin";
            this.metroSetButton_bookmark1.ThemeName = "MetroLite";
            this.metroSetButton_bookmark1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroSetButton_bookmark_MouseClick);
            this.metroSetButton_bookmark1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroSetButton_bookmark_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 347);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "투명브라우저(Chrome) v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_sizecontrol;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_showhide;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_exit;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox_url;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_bookmark1;
        private System.Windows.Forms.Panel panel_padding1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_bookmark2;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_bookmark3;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_bookmark4;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_bookmark5;
        private System.Windows.Forms.Panel panel_padding4;
        private System.Windows.Forms.Panel panel_padding3;
        private System.Windows.Forms.Panel panel_padding2;
        private System.Windows.Forms.Panel panel1_padding1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_minimize;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_maximzie;
        private System.Windows.Forms.Panel panel1_padding2;
        private System.Windows.Forms.Panel panel1_padding3;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_search;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_back;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_forward;
        private System.Windows.Forms.Panel panel2_padding2;
        private System.Windows.Forms.Panel panel2_padding1;
    }
}

