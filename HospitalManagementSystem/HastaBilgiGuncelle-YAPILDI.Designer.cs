
namespace HospitalManagementSystem
{
    partial class HastaBilgiGuncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaBilgiGuncelle));
            this.bilgilerim = new System.Windows.Forms.Label();
            this.DogduguSehir = new System.Windows.Forms.ComboBox();
            this.rButonKadın = new System.Windows.Forms.RadioButton();
            this.rButonErkek = new System.Windows.Forms.RadioButton();
            this.txtHMail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtHSAd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtHAd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtHTCKN = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TCKN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.bilgilerimiGuncelleButon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hykCıkısButon = new Bunifu.Framework.UI.BunifuImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cmbKanGrubu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.hykCıkısButon)).BeginInit();
            this.SuspendLayout();
            // 
            // bilgilerim
            // 
            this.bilgilerim.AutoSize = true;
            this.bilgilerim.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgilerim.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bilgilerim.Location = new System.Drawing.Point(38, 32);
            this.bilgilerim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bilgilerim.Name = "bilgilerim";
            this.bilgilerim.Size = new System.Drawing.Size(115, 20);
            this.bilgilerim.TabIndex = 1;
            this.bilgilerim.Text = "Kişisel Bilgilerim";
            // 
            // DogduguSehir
            // 
            this.DogduguSehir.BackColor = System.Drawing.Color.White;
            this.DogduguSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DogduguSehir.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DogduguSehir.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.DogduguSehir.FormattingEnabled = true;
            this.DogduguSehir.Location = new System.Drawing.Point(128, 309);
            this.DogduguSehir.Margin = new System.Windows.Forms.Padding(2);
            this.DogduguSehir.Name = "DogduguSehir";
            this.DogduguSehir.Size = new System.Drawing.Size(176, 25);
            this.DogduguSehir.TabIndex = 6;
            this.DogduguSehir.SelectedIndexChanged += new System.EventHandler(this.DogduguSehir_SelectedIndexChanged);
            this.DogduguSehir.SelectedValueChanged += new System.EventHandler(this.DogduguSehir_SelectedValueChanged);
            // 
            // rButonKadın
            // 
            this.rButonKadın.AutoSize = true;
            this.rButonKadın.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rButonKadın.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rButonKadın.Location = new System.Drawing.Point(136, 267);
            this.rButonKadın.Margin = new System.Windows.Forms.Padding(2);
            this.rButonKadın.Name = "rButonKadın";
            this.rButonKadın.Size = new System.Drawing.Size(67, 23);
            this.rButonKadın.TabIndex = 4;
            this.rButonKadın.TabStop = true;
            this.rButonKadın.Text = "Kadın";
            this.rButonKadın.UseVisualStyleBackColor = true;
            // 
            // rButonErkek
            // 
            this.rButonErkek.AutoSize = true;
            this.rButonErkek.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rButonErkek.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rButonErkek.Location = new System.Drawing.Point(214, 267);
            this.rButonErkek.Margin = new System.Windows.Forms.Padding(2);
            this.rButonErkek.Name = "rButonErkek";
            this.rButonErkek.Size = new System.Drawing.Size(62, 23);
            this.rButonErkek.TabIndex = 5;
            this.rButonErkek.TabStop = true;
            this.rButonErkek.Text = "Erkek";
            this.rButonErkek.UseVisualStyleBackColor = true;
            // 
            // txtHMail
            // 
            this.txtHMail.BackColor = System.Drawing.Color.White;
            this.txtHMail.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtHMail.BorderColorIdle = System.Drawing.Color.CadetBlue;
            this.txtHMail.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtHMail.BorderThickness = 1;
            this.txtHMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHMail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHMail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtHMail.isPassword = false;
            this.txtHMail.Location = new System.Drawing.Point(453, 294);
            this.txtHMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtHMail.Name = "txtHMail";
            this.txtHMail.Size = new System.Drawing.Size(176, 37);
            this.txtHMail.TabIndex = 10;
            this.txtHMail.Text = "E-Mail";
            this.txtHMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtHSAd
            // 
            this.txtHSAd.BackColor = System.Drawing.Color.White;
            this.txtHSAd.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtHSAd.BorderColorIdle = System.Drawing.Color.CadetBlue;
            this.txtHSAd.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtHSAd.BorderThickness = 1;
            this.txtHSAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHSAd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHSAd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtHSAd.isPassword = false;
            this.txtHSAd.Location = new System.Drawing.Point(128, 209);
            this.txtHSAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtHSAd.Name = "txtHSAd";
            this.txtHSAd.Size = new System.Drawing.Size(176, 37);
            this.txtHSAd.TabIndex = 3;
            this.txtHSAd.Text = "Soyad";
            this.txtHSAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtHAd
            // 
            this.txtHAd.BackColor = System.Drawing.Color.White;
            this.txtHAd.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtHAd.BorderColorIdle = System.Drawing.Color.CadetBlue;
            this.txtHAd.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtHAd.BorderThickness = 1;
            this.txtHAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHAd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHAd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtHAd.isPassword = false;
            this.txtHAd.Location = new System.Drawing.Point(128, 146);
            this.txtHAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtHAd.Name = "txtHAd";
            this.txtHAd.Size = new System.Drawing.Size(176, 37);
            this.txtHAd.TabIndex = 2;
            this.txtHAd.Text = "Ad";
            this.txtHAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtHTCKN
            // 
            this.txtHTCKN.BackColor = System.Drawing.Color.White;
            this.txtHTCKN.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtHTCKN.BorderColorIdle = System.Drawing.Color.CadetBlue;
            this.txtHTCKN.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtHTCKN.BorderThickness = 1;
            this.txtHTCKN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHTCKN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHTCKN.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtHTCKN.isPassword = false;
            this.txtHTCKN.Location = new System.Drawing.Point(128, 91);
            this.txtHTCKN.Margin = new System.Windows.Forms.Padding(4);
            this.txtHTCKN.Name = "txtHTCKN";
            this.txtHTCKN.Size = new System.Drawing.Size(176, 37);
            this.txtHTCKN.TabIndex = 1;
            this.txtHTCKN.Text = "TC Kimlik No";
            this.txtHTCKN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHTCKN.OnValueChanged += new System.EventHandler(this.txtHTCKN_OnValueChanged);
            this.txtHTCKN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHTCKN_KeyPress);
            // 
            // TCKN
            // 
            this.TCKN.AutoSize = true;
            this.TCKN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TCKN.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TCKN.Location = new System.Drawing.Point(54, 101);
            this.TCKN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TCKN.Name = "TCKN";
            this.TCKN.Size = new System.Drawing.Size(56, 19);
            this.TCKN.TabIndex = 48;
            this.TCKN.Text = "TC No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(74, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(54, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(335, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Doğum Tarihi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(341, 228);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 56;
            this.label8.Text = "Cep Tel. No :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(377, 307);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 57;
            this.label9.Text = "E-Mail :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(21, 315);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 19);
            this.label11.TabIndex = 59;
            this.label11.Text = "Doğum Yeri :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Location = new System.Drawing.Point(344, 156);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 19);
            this.label12.TabIndex = 60;
            this.label12.Text = "Kan Grubu : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(45, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 61;
            this.label4.Text = "Cinsiyet :";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(453, 91);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(176, 25);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox2.Location = new System.Drawing.Point(453, 219);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox2.Mask = "(999) 000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(176, 25);
            this.maskedTextBox2.TabIndex = 9;
            // 
            // bilgilerimiGuncelleButon
            // 
            this.bilgilerimiGuncelleButon.ActiveBorderThickness = 1;
            this.bilgilerimiGuncelleButon.ActiveCornerRadius = 20;
            this.bilgilerimiGuncelleButon.ActiveFillColor = System.Drawing.Color.DarkCyan;
            this.bilgilerimiGuncelleButon.ActiveForecolor = System.Drawing.Color.White;
            this.bilgilerimiGuncelleButon.ActiveLineColor = System.Drawing.Color.DarkCyan;
            this.bilgilerimiGuncelleButon.BackColor = System.Drawing.Color.White;
            this.bilgilerimiGuncelleButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bilgilerimiGuncelleButon.BackgroundImage")));
            this.bilgilerimiGuncelleButon.ButtonText = "Bilgilerimi Güncelle";
            this.bilgilerimiGuncelleButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bilgilerimiGuncelleButon.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgilerimiGuncelleButon.ForeColor = System.Drawing.Color.DarkCyan;
            this.bilgilerimiGuncelleButon.IdleBorderThickness = 1;
            this.bilgilerimiGuncelleButon.IdleCornerRadius = 20;
            this.bilgilerimiGuncelleButon.IdleFillColor = System.Drawing.Color.White;
            this.bilgilerimiGuncelleButon.IdleForecolor = System.Drawing.Color.DarkCyan;
            this.bilgilerimiGuncelleButon.IdleLineColor = System.Drawing.Color.DarkCyan;
            this.bilgilerimiGuncelleButon.Location = new System.Drawing.Point(499, 416);
            this.bilgilerimiGuncelleButon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bilgilerimiGuncelleButon.Name = "bilgilerimiGuncelleButon";
            this.bilgilerimiGuncelleButon.Size = new System.Drawing.Size(130, 45);
            this.bilgilerimiGuncelleButon.TabIndex = 11;
            this.bilgilerimiGuncelleButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bilgilerimiGuncelleButon.Click += new System.EventHandler(this.bilgilerimiGuncelleButon_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 524);
            this.panel3.TabIndex = 66;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 4);
            this.panel1.TabIndex = 65;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(671, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 520);
            this.panel4.TabIndex = 68;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(4, 524);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 4);
            this.panel2.TabIndex = 67;
            // 
            // hykCıkısButon
            // 
            this.hykCıkısButon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hykCıkısButon.BackColor = System.Drawing.Color.White;
            this.hykCıkısButon.Image = ((System.Drawing.Image)(resources.GetObject("hykCıkısButon.Image")));
            this.hykCıkısButon.ImageActive = null;
            this.hykCıkısButon.Location = new System.Drawing.Point(628, 10);
            this.hykCıkısButon.Margin = new System.Windows.Forms.Padding(2);
            this.hykCıkısButon.Name = "hykCıkısButon";
            this.hykCıkısButon.Size = new System.Drawing.Size(38, 41);
            this.hykCıkısButon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hykCıkısButon.TabIndex = 69;
            this.hykCıkısButon.TabStop = false;
            this.hykCıkısButon.Zoom = 5;
            this.hykCıkısButon.Click += new System.EventHandler(this.hykCıkısButon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(52, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 71;
            this.label5.Text = "Şifre :";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtSifre.BorderColorIdle = System.Drawing.Color.CadetBlue;
            this.txtSifre.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtSifre.BorderThickness = 1;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSifre.isPassword = false;
            this.txtSifre.Location = new System.Drawing.Point(128, 353);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(176, 37);
            this.txtSifre.TabIndex = 70;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.BackColor = System.Drawing.Color.White;
            this.cmbKanGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKanGrubu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKanGrubu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cmbKanGrubu.FormattingEnabled = true;
            this.cmbKanGrubu.Location = new System.Drawing.Point(453, 154);
            this.cmbKanGrubu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKanGrubu.Name = "cmbKanGrubu";
            this.cmbKanGrubu.Size = new System.Drawing.Size(176, 25);
            this.cmbKanGrubu.TabIndex = 72;
            // 
            // HastaBilgiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 528);
            this.Controls.Add(this.cmbKanGrubu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.hykCıkısButon);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bilgilerimiGuncelleButon);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rButonErkek);
            this.Controls.Add(this.rButonKadın);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TCKN);
            this.Controls.Add(this.DogduguSehir);
            this.Controls.Add(this.txtHMail);
            this.Controls.Add(this.txtHSAd);
            this.Controls.Add(this.txtHAd);
            this.Controls.Add(this.txtHTCKN);
            this.Controls.Add(this.bilgilerim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HastaBilgiGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaBilgiGuncelle";
            this.Load += new System.EventHandler(this.HastaBilgiGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hykCıkısButon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bilgilerim;
        private System.Windows.Forms.ComboBox DogduguSehir;
        private System.Windows.Forms.RadioButton rButonKadın;
        private System.Windows.Forms.RadioButton rButonErkek;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHMail;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHSAd;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHAd;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHTCKN;
        private System.Windows.Forms.Label TCKN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 bilgilerimiGuncelleButon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton hykCıkısButon;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSifre;
        private System.Windows.Forms.ComboBox cmbKanGrubu;
    }
}