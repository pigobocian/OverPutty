namespace OverPutty
{
    partial class FormHost
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
            this.HostNameEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CompressCheckBox = new System.Windows.Forms.CheckBox();
            this.TCPGroupBox = new System.Windows.Forms.GroupBox();
            this.NoTCPVerRadioButton = new System.Windows.Forms.RadioButton();
            this.TCP6VerRadioButton = new System.Windows.Forms.RadioButton();
            this.TCP4VerRadioButton = new System.Windows.Forms.RadioButton();
            this.SSHVerGroupBox = new System.Windows.Forms.GroupBox();
            this.NoSSHVerRadioButton = new System.Windows.Forms.RadioButton();
            this.SSHVer2RadioButton = new System.Windows.Forms.RadioButton();
            this.SSHVer1RadioButton = new System.Windows.Forms.RadioButton();
            this.ProtocolGroupBox = new System.Windows.Forms.GroupBox();
            this.SerialRadioButton = new System.Windows.Forms.RadioButton();
            this.RAWRadioButton = new System.Windows.Forms.RadioButton();
            this.RloginRadioButton = new System.Windows.Forms.RadioButton();
            this.TelnetRadioButton = new System.Windows.Forms.RadioButton();
            this.SSHRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.PortEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordEdit = new System.Windows.Forms.TextBox();
            this.UserEdit = new System.Windows.Forms.TextBox();
            this.HostEdit = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.EditAddCmd9 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.EditAddCmd8 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.EditAddCmd7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.EditAddCmd6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.EditAddCmd5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.EditAddCmd4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EditAddCmd3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EditAddCmd2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EditAddCmd1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LoadPrivKeyButton = new System.Windows.Forms.Button();
            this.ClearPrivKeyButton = new System.Windows.Forms.Button();
            this.PrivKeyEdit = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ChangeGroupButton = new System.Windows.Forms.Button();
            this.GroupInfoLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TCPGroupBox.SuspendLayout();
            this.SSHVerGroupBox.SuspendLayout();
            this.ProtocolGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // HostNameEdit
            // 
            this.HostNameEdit.Location = new System.Drawing.Point(12, 36);
            this.HostNameEdit.Name = "HostNameEdit";
            this.HostNameEdit.Size = new System.Drawing.Size(448, 20);
            this.HostNameEdit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa opisowa";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 149);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 417);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CompressCheckBox);
            this.tabPage1.Controls.Add(this.TCPGroupBox);
            this.tabPage1.Controls.Add(this.SSHVerGroupBox);
            this.tabPage1.Controls.Add(this.ProtocolGroupBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.PortEdit);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.PasswordEdit);
            this.tabPage1.Controls.Add(this.UserEdit);
            this.tabPage1.Controls.Add(this.HostEdit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Podstawowe";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CompressCheckBox
            // 
            this.CompressCheckBox.AutoSize = true;
            this.CompressCheckBox.Location = new System.Drawing.Point(338, 38);
            this.CompressCheckBox.Name = "CompressCheckBox";
            this.CompressCheckBox.Size = new System.Drawing.Size(75, 17);
            this.CompressCheckBox.TabIndex = 29;
            this.CompressCheckBox.Text = "Kompresja";
            this.CompressCheckBox.UseVisualStyleBackColor = true;
            // 
            // TCPGroupBox
            // 
            this.TCPGroupBox.Controls.Add(this.NoTCPVerRadioButton);
            this.TCPGroupBox.Controls.Add(this.TCP6VerRadioButton);
            this.TCPGroupBox.Controls.Add(this.TCP4VerRadioButton);
            this.TCPGroupBox.Location = new System.Drawing.Point(293, 128);
            this.TCPGroupBox.Name = "TCPGroupBox";
            this.TCPGroupBox.Size = new System.Drawing.Size(132, 144);
            this.TCPGroupBox.TabIndex = 10;
            this.TCPGroupBox.TabStop = false;
            this.TCPGroupBox.Text = "Wersja protokołu TCP";
            // 
            // NoTCPVerRadioButton
            // 
            this.NoTCPVerRadioButton.AutoSize = true;
            this.NoTCPVerRadioButton.Checked = true;
            this.NoTCPVerRadioButton.Location = new System.Drawing.Point(14, 114);
            this.NoTCPVerRadioButton.Name = "NoTCPVerRadioButton";
            this.NoTCPVerRadioButton.Size = new System.Drawing.Size(84, 17);
            this.NoTCPVerRadioButton.TabIndex = 2;
            this.NoTCPVerRadioButton.TabStop = true;
            this.NoTCPVerRadioButton.Text = "Nie podawaj";
            this.NoTCPVerRadioButton.UseVisualStyleBackColor = true;
            // 
            // TCP6VerRadioButton
            // 
            this.TCP6VerRadioButton.AutoSize = true;
            this.TCP6VerRadioButton.Location = new System.Drawing.Point(14, 67);
            this.TCP6VerRadioButton.Name = "TCP6VerRadioButton";
            this.TCP6VerRadioButton.Size = new System.Drawing.Size(67, 17);
            this.TCP6VerRadioButton.TabIndex = 1;
            this.TCP6VerRadioButton.TabStop = true;
            this.TCP6VerRadioButton.Text = "Wersja 6";
            this.TCP6VerRadioButton.UseVisualStyleBackColor = true;
            // 
            // TCP4VerRadioButton
            // 
            this.TCP4VerRadioButton.AutoSize = true;
            this.TCP4VerRadioButton.Location = new System.Drawing.Point(14, 20);
            this.TCP4VerRadioButton.Name = "TCP4VerRadioButton";
            this.TCP4VerRadioButton.Size = new System.Drawing.Size(67, 17);
            this.TCP4VerRadioButton.TabIndex = 0;
            this.TCP4VerRadioButton.TabStop = true;
            this.TCP4VerRadioButton.Text = "Wersja 4";
            this.TCP4VerRadioButton.UseVisualStyleBackColor = true;
            // 
            // SSHVerGroupBox
            // 
            this.SSHVerGroupBox.Controls.Add(this.NoSSHVerRadioButton);
            this.SSHVerGroupBox.Controls.Add(this.SSHVer2RadioButton);
            this.SSHVerGroupBox.Controls.Add(this.SSHVer1RadioButton);
            this.SSHVerGroupBox.Location = new System.Drawing.Point(155, 128);
            this.SSHVerGroupBox.Name = "SSHVerGroupBox";
            this.SSHVerGroupBox.Size = new System.Drawing.Size(132, 144);
            this.SSHVerGroupBox.TabIndex = 9;
            this.SSHVerGroupBox.TabStop = false;
            this.SSHVerGroupBox.Text = "Wersja protokołu SSH";
            // 
            // NoSSHVerRadioButton
            // 
            this.NoSSHVerRadioButton.AutoSize = true;
            this.NoSSHVerRadioButton.Checked = true;
            this.NoSSHVerRadioButton.Location = new System.Drawing.Point(9, 114);
            this.NoSSHVerRadioButton.Name = "NoSSHVerRadioButton";
            this.NoSSHVerRadioButton.Size = new System.Drawing.Size(84, 17);
            this.NoSSHVerRadioButton.TabIndex = 2;
            this.NoSSHVerRadioButton.TabStop = true;
            this.NoSSHVerRadioButton.Text = "Nie podawaj";
            this.NoSSHVerRadioButton.UseVisualStyleBackColor = true;
            // 
            // SSHVer2RadioButton
            // 
            this.SSHVer2RadioButton.AutoSize = true;
            this.SSHVer2RadioButton.Location = new System.Drawing.Point(9, 67);
            this.SSHVer2RadioButton.Name = "SSHVer2RadioButton";
            this.SSHVer2RadioButton.Size = new System.Drawing.Size(88, 17);
            this.SSHVer2RadioButton.TabIndex = 1;
            this.SSHVer2RadioButton.TabStop = true;
            this.SSHVer2RadioButton.Text = "Wersja druga";
            this.SSHVer2RadioButton.UseVisualStyleBackColor = true;
            // 
            // SSHVer1RadioButton
            // 
            this.SSHVer1RadioButton.AutoSize = true;
            this.SSHVer1RadioButton.Location = new System.Drawing.Point(9, 20);
            this.SSHVer1RadioButton.Name = "SSHVer1RadioButton";
            this.SSHVer1RadioButton.Size = new System.Drawing.Size(102, 17);
            this.SSHVer1RadioButton.TabIndex = 0;
            this.SSHVer1RadioButton.TabStop = true;
            this.SSHVer1RadioButton.Text = "Wersja pierwsza";
            this.SSHVer1RadioButton.UseVisualStyleBackColor = true;
            // 
            // ProtocolGroupBox
            // 
            this.ProtocolGroupBox.Controls.Add(this.SerialRadioButton);
            this.ProtocolGroupBox.Controls.Add(this.RAWRadioButton);
            this.ProtocolGroupBox.Controls.Add(this.RloginRadioButton);
            this.ProtocolGroupBox.Controls.Add(this.TelnetRadioButton);
            this.ProtocolGroupBox.Controls.Add(this.SSHRadioButton);
            this.ProtocolGroupBox.Location = new System.Drawing.Point(17, 128);
            this.ProtocolGroupBox.Name = "ProtocolGroupBox";
            this.ProtocolGroupBox.Size = new System.Drawing.Size(132, 144);
            this.ProtocolGroupBox.TabIndex = 8;
            this.ProtocolGroupBox.TabStop = false;
            this.ProtocolGroupBox.Text = "Protokół";
            // 
            // SerialRadioButton
            // 
            this.SerialRadioButton.AutoSize = true;
            this.SerialRadioButton.Location = new System.Drawing.Point(15, 116);
            this.SerialRadioButton.Name = "SerialRadioButton";
            this.SerialRadioButton.Size = new System.Drawing.Size(49, 17);
            this.SerialRadioButton.TabIndex = 4;
            this.SerialRadioButton.Text = "serial";
            this.SerialRadioButton.UseVisualStyleBackColor = true;
            // 
            // RAWRadioButton
            // 
            this.RAWRadioButton.AutoSize = true;
            this.RAWRadioButton.Location = new System.Drawing.Point(15, 92);
            this.RAWRadioButton.Name = "RAWRadioButton";
            this.RAWRadioButton.Size = new System.Drawing.Size(42, 17);
            this.RAWRadioButton.TabIndex = 3;
            this.RAWRadioButton.Text = "raw";
            this.RAWRadioButton.UseVisualStyleBackColor = true;
            // 
            // RloginRadioButton
            // 
            this.RloginRadioButton.AutoSize = true;
            this.RloginRadioButton.Location = new System.Drawing.Point(15, 68);
            this.RloginRadioButton.Name = "RloginRadioButton";
            this.RloginRadioButton.Size = new System.Drawing.Size(50, 17);
            this.RloginRadioButton.TabIndex = 2;
            this.RloginRadioButton.Text = "rlogin";
            this.RloginRadioButton.UseVisualStyleBackColor = true;
            // 
            // TelnetRadioButton
            // 
            this.TelnetRadioButton.AutoSize = true;
            this.TelnetRadioButton.Location = new System.Drawing.Point(15, 44);
            this.TelnetRadioButton.Name = "TelnetRadioButton";
            this.TelnetRadioButton.Size = new System.Drawing.Size(55, 17);
            this.TelnetRadioButton.TabIndex = 1;
            this.TelnetRadioButton.Text = "Telnet";
            this.TelnetRadioButton.UseVisualStyleBackColor = true;
            // 
            // SSHRadioButton
            // 
            this.SSHRadioButton.AutoSize = true;
            this.SSHRadioButton.Checked = true;
            this.SSHRadioButton.Location = new System.Drawing.Point(15, 20);
            this.SSHRadioButton.Name = "SSHRadioButton";
            this.SSHRadioButton.Size = new System.Drawing.Size(47, 17);
            this.SSHRadioButton.TabIndex = 0;
            this.SSHRadioButton.TabStop = true;
            this.SSHRadioButton.Text = "SSH";
            this.SSHRadioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Port";
            // 
            // PortEdit
            // 
            this.PortEdit.Location = new System.Drawing.Point(169, 38);
            this.PortEdit.Name = "PortEdit";
            this.PortEdit.Size = new System.Drawing.Size(146, 20);
            this.PortEdit.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Hasło";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Użytkownik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Adres hosta";
            // 
            // PasswordEdit
            // 
            this.PasswordEdit.Location = new System.Drawing.Point(169, 88);
            this.PasswordEdit.Name = "PasswordEdit";
            this.PasswordEdit.Size = new System.Drawing.Size(146, 20);
            this.PasswordEdit.TabIndex = 5;
            // 
            // UserEdit
            // 
            this.UserEdit.Location = new System.Drawing.Point(17, 88);
            this.UserEdit.Name = "UserEdit";
            this.UserEdit.Size = new System.Drawing.Size(146, 20);
            this.UserEdit.TabIndex = 4;
            // 
            // HostEdit
            // 
            this.HostEdit.Location = new System.Drawing.Point(17, 38);
            this.HostEdit.Name = "HostEdit";
            this.HostEdit.Size = new System.Drawing.Size(146, 20);
            this.HostEdit.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.EditAddCmd9);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.EditAddCmd8);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.EditAddCmd7);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.EditAddCmd6);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.EditAddCmd5);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.EditAddCmd4);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.EditAddCmd3);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.EditAddCmd2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.EditAddCmd1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Opcje dodatkowe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // EditAddCmd9
            // 
            this.EditAddCmd9.Location = new System.Drawing.Point(18, 353);
            this.EditAddCmd9.Name = "EditAddCmd9";
            this.EditAddCmd9.Size = new System.Drawing.Size(405, 20);
            this.EditAddCmd9.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 337);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Dodatkowa opcja, nr.9";
            // 
            // EditAddCmd8
            // 
            this.EditAddCmd8.Location = new System.Drawing.Point(18, 313);
            this.EditAddCmd8.Name = "EditAddCmd8";
            this.EditAddCmd8.Size = new System.Drawing.Size(405, 20);
            this.EditAddCmd8.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 297);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Dodatkowa opcja, nr.8";
            // 
            // EditAddCmd7
            // 
            this.EditAddCmd7.Location = new System.Drawing.Point(18, 274);
            this.EditAddCmd7.Name = "EditAddCmd7";
            this.EditAddCmd7.Size = new System.Drawing.Size(405, 20);
            this.EditAddCmd7.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Dodatkowa opcja, nr.7";
            // 
            // EditAddCmd6
            // 
            this.EditAddCmd6.Location = new System.Drawing.Point(18, 233);
            this.EditAddCmd6.Name = "EditAddCmd6";
            this.EditAddCmd6.Size = new System.Drawing.Size(405, 20);
            this.EditAddCmd6.TabIndex = 16;
            this.EditAddCmd6.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Dodatkowa opcja, nr.6";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // EditAddCmd5
            // 
            this.EditAddCmd5.Location = new System.Drawing.Point(18, 193);
            this.EditAddCmd5.Name = "EditAddCmd5";
            this.EditAddCmd5.Size = new System.Drawing.Size(405, 20);
            this.EditAddCmd5.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Dodatkowa opcja, nr.5";
            // 
            // EditAddCmd4
            // 
            this.EditAddCmd4.Location = new System.Drawing.Point(18, 153);
            this.EditAddCmd4.Name = "EditAddCmd4";
            this.EditAddCmd4.Size = new System.Drawing.Size(405, 20);
            this.EditAddCmd4.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Dodatkowa opcja, nr.4";
            // 
            // EditAddCmd3
            // 
            this.EditAddCmd3.Location = new System.Drawing.Point(18, 114);
            this.EditAddCmd3.Name = "EditAddCmd3";
            this.EditAddCmd3.Size = new System.Drawing.Size(405, 20);
            this.EditAddCmd3.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Dodatkowa opcja, nr.3";
            // 
            // EditAddCmd2
            // 
            this.EditAddCmd2.Location = new System.Drawing.Point(18, 75);
            this.EditAddCmd2.Name = "EditAddCmd2";
            this.EditAddCmd2.Size = new System.Drawing.Size(405, 20);
            this.EditAddCmd2.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Dodatkowa opcja, nr.2";
            // 
            // EditAddCmd1
            // 
            this.EditAddCmd1.Location = new System.Drawing.Point(18, 35);
            this.EditAddCmd1.Name = "EditAddCmd1";
            this.EditAddCmd1.Size = new System.Drawing.Size(405, 20);
            this.EditAddCmd1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dodatkowa opcja, nr.1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LoadPrivKeyButton);
            this.tabPage3.Controls.Add(this.ClearPrivKeyButton);
            this.tabPage3.Controls.Add(this.PrivKeyEdit);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(441, 391);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Klucz prywatny";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LoadPrivKeyButton
            // 
            this.LoadPrivKeyButton.Location = new System.Drawing.Point(348, 336);
            this.LoadPrivKeyButton.Name = "LoadPrivKeyButton";
            this.LoadPrivKeyButton.Size = new System.Drawing.Size(75, 32);
            this.LoadPrivKeyButton.TabIndex = 8;
            this.LoadPrivKeyButton.Text = "Wczytaj";
            this.LoadPrivKeyButton.UseVisualStyleBackColor = true;
            this.LoadPrivKeyButton.Click += new System.EventHandler(this.LoadPrivKeyButton_Click);
            // 
            // ClearPrivKeyButton
            // 
            this.ClearPrivKeyButton.Location = new System.Drawing.Point(14, 336);
            this.ClearPrivKeyButton.Name = "ClearPrivKeyButton";
            this.ClearPrivKeyButton.Size = new System.Drawing.Size(75, 32);
            this.ClearPrivKeyButton.TabIndex = 1;
            this.ClearPrivKeyButton.Text = "Czyść";
            this.ClearPrivKeyButton.UseVisualStyleBackColor = true;
            this.ClearPrivKeyButton.Click += new System.EventHandler(this.ClearPrivKeyButton_Click);
            // 
            // PrivKeyEdit
            // 
            this.PrivKeyEdit.Location = new System.Drawing.Point(14, 26);
            this.PrivKeyEdit.Multiline = true;
            this.PrivKeyEdit.Name = "PrivKeyEdit";
            this.PrivKeyEdit.Size = new System.Drawing.Size(409, 300);
            this.PrivKeyEdit.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ChangeGroupButton);
            this.groupBox5.Controls.Add(this.GroupInfoLabel);
            this.groupBox5.Location = new System.Drawing.Point(12, 71);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(449, 61);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Przypisana grupa";
            // 
            // ChangeGroupButton
            // 
            this.ChangeGroupButton.Location = new System.Drawing.Point(317, 22);
            this.ChangeGroupButton.Name = "ChangeGroupButton";
            this.ChangeGroupButton.Size = new System.Drawing.Size(121, 23);
            this.ChangeGroupButton.TabIndex = 1;
            this.ChangeGroupButton.Text = "Zmień grupę";
            this.ChangeGroupButton.UseVisualStyleBackColor = true;
            // 
            // GroupInfoLabel
            // 
            this.GroupInfoLabel.AutoSize = true;
            this.GroupInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupInfoLabel.Location = new System.Drawing.Point(15, 25);
            this.GroupInfoLabel.Name = "GroupInfoLabel";
            this.GroupInfoLabel.Size = new System.Drawing.Size(52, 17);
            this.GroupInfoLabel.TabIndex = 19;
            this.GroupInfoLabel.Text = "label3";
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(382, 572);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 34);
            this.OKButton.TabIndex = 20;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(301, 572);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 34);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Rezygnuj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FormHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 612);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HostNameEdit);
            this.Name = "FormHost";
            this.Text = "Form4";
            this.Shown += new System.EventHandler(this.FormHost_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TCPGroupBox.ResumeLayout(false);
            this.TCPGroupBox.PerformLayout();
            this.SSHVerGroupBox.ResumeLayout(false);
            this.SSHVerGroupBox.PerformLayout();
            this.ProtocolGroupBox.ResumeLayout(false);
            this.ProtocolGroupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HostNameEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox CompressCheckBox;
        private System.Windows.Forms.GroupBox TCPGroupBox;
        private System.Windows.Forms.RadioButton NoTCPVerRadioButton;
        private System.Windows.Forms.RadioButton TCP6VerRadioButton;
        private System.Windows.Forms.RadioButton TCP4VerRadioButton;
        private System.Windows.Forms.GroupBox SSHVerGroupBox;
        private System.Windows.Forms.RadioButton NoSSHVerRadioButton;
        private System.Windows.Forms.RadioButton SSHVer2RadioButton;
        private System.Windows.Forms.RadioButton SSHVer1RadioButton;
        private System.Windows.Forms.GroupBox ProtocolGroupBox;
        private System.Windows.Forms.RadioButton SerialRadioButton;
        private System.Windows.Forms.RadioButton RAWRadioButton;
        private System.Windows.Forms.RadioButton RloginRadioButton;
        private System.Windows.Forms.RadioButton TelnetRadioButton;
        private System.Windows.Forms.RadioButton SSHRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PortEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordEdit;
        private System.Windows.Forms.TextBox UserEdit;
        private System.Windows.Forms.TextBox HostEdit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox EditAddCmd8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox EditAddCmd7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox EditAddCmd6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox EditAddCmd5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EditAddCmd4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EditAddCmd3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox EditAddCmd2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EditAddCmd1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EditAddCmd9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button ChangeGroupButton;
        private System.Windows.Forms.Label GroupInfoLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button LoadPrivKeyButton;
        private System.Windows.Forms.Button ClearPrivKeyButton;
        private System.Windows.Forms.TextBox PrivKeyEdit;
    }
}