using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace OverPutty
{
    public partial class FormHost : Form
    {
        
        int id_group = 0;
        string groupName = "";
        ModalResult modalResult = ModalResult.mrCancel;

        public FormHost()
        {
            InitializeComponent();
        }

        public FormHost(string caption, string groupName, int id_hostGroup)
        {
            InitializeComponent();
            this.Text = caption;
            GroupInfoLabel.Text = groupName;
            this.groupName = groupName;
            this.id_group = id_hostGroup;
        }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            modalResult = ModalResult.mrOK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            modalResult = ModalResult.mrCancel;
            this.Close();
        }

        public void ClearForm()
        {
            HostNameEdit.Clear();
            PortEdit.Clear();
            HostEdit.Clear();
            UserEdit.Clear();
            PasswordEdit.Clear();
            CompressCheckBox.Checked = true;
            NoSSHVerRadioButton.Checked = true;
            SSHRadioButton.Checked = true;
            NoTCPVerRadioButton.Checked = true;
            PrivKeyEdit.Clear();
            EditAddCmd1.Clear();
            EditAddCmd2.Clear();
            EditAddCmd3.Clear();
            EditAddCmd4.Clear();
            EditAddCmd5.Clear();
            EditAddCmd6.Clear();
            EditAddCmd7.Clear();
            EditAddCmd8.Clear();
            EditAddCmd9.Clear();
        }

        private void AddHost()
        {
            ClearForm();
            this.ShowDialog();
            if (modalResult != ModalResult.mrOK) return;
            
            string name = HostNameEdit.Text;
            string port = PortEdit.Text;
            string host = HostEdit.Text;
            string user = UserEdit.Text;
            string pass = PasswordEdit.Text;
            bool compress = CompressCheckBox.Checked;

            SSHVersion ssh_ver = SSHVersion.NotSpecyfied;
            if (SSHVer1RadioButton.Checked) ssh_ver = SSHVersion.Ver1;
            if (SSHVer2RadioButton.Checked) ssh_ver = SSHVersion.Ver2;
            if (NoSSHVerRadioButton.Checked) ssh_ver = SSHVersion.NotSpecyfied;

            ProtocolType protocol = ProtocolType.SSH;
            if (SSHRadioButton.Checked) protocol = ProtocolType.SSH;
            if (TelnetRadioButton.Checked) protocol = ProtocolType.Telnet;
            if (RloginRadioButton.Checked) protocol = ProtocolType.Rlogin;
            if (RAWRadioButton.Checked) protocol = ProtocolType.RAW;
            if (SerialRadioButton.Checked) protocol = ProtocolType.Serial;

            TCPVersion tcpVer = TCPVersion.NotSpecyfied;
            if (TCP4VerRadioButton.Checked) tcpVer = TCPVersion.TCPVer4;
            if (TCP6VerRadioButton.Checked) tcpVer = TCPVersion.TCPVer6;
            if (NoTCPVerRadioButton.Checked) tcpVer = TCPVersion.NotSpecyfied;

            string privKey = PrivKeyEdit.Text;

            string addCmd1 = EditAddCmd1.Text;
            string addCmd2 = EditAddCmd2.Text;
            string addCmd3 = EditAddCmd3.Text;
            string addCmd4 = EditAddCmd4.Text;
            string addCmd5 = EditAddCmd5.Text;
            string addCmd6 = EditAddCmd6.Text;
            string addCmd7 = EditAddCmd7.Text;
            string addCmd8 = EditAddCmd8.Text;
            string addCmd9 = EditAddCmd9.Text;

            Our.db.AddHost(this.id_group, name, port, user, pass,
                compress, (int)ssh_ver, (int)protocol, (int)tcpVer,
                privKey, addCmd1, addCmd2, addCmd3, addCmd4, addCmd5,
                addCmd6, addCmd7, addCmd8, addCmd9);
        }


        public void LoadFormFromDB(int id_host)
        {
            ClearForm();

            try
            {
                string sql = DBInterface.GetHostSelectString()
                    + " where "
                    + DBInterface.HOST_ID_HOST
                    + " = "
                    + id_host.ToString();

                SQLiteCommand cmd = new SQLiteCommand(sql, Our.db.GetConnection());
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string hostName = reader.GetString(2);
                    HostNameEdit.Text = hostName;

                    int port = reader.GetInt32(3);
                    PortEdit.Text = port.ToString();

                    string host = reader.GetString(4);
                    HostEdit.Text = host;

                    string user = reader.GetString(5);
                    UserEdit.Text = user;

                    string pass = reader.GetString(6);
                    PasswordEdit.Text = pass;

                    bool compress = reader.GetBoolean(7);
                    CompressCheckBox.Checked = compress;
                    
                    int sshVer = reader.GetInt32(8);
                    switch(sshVer)
                    {
                        case 0: NoSSHVerRadioButton.Checked = true; break;
                        case 1: SSHVer1RadioButton.Checked = true; break;
                        case 2: SSHVer2RadioButton.Checked = true; break;
                    }
                    
                    int protocol = reader.GetInt32(9);
                    switch(protocol)
                    {
                        case 0: SSHRadioButton.Checked = true; break;
                        case 1: TelnetRadioButton.Checked = true; break;
                        case 2: RloginRadioButton.Checked = true; break;
                        case 3: RAWRadioButton.Checked = true; break;
                        case 4: SerialRadioButton.Checked = true; break;
                    }

                    int tcpVer = reader.GetInt32(10);
                    switch (tcpVer)
                    {
                        case 0: NoTCPVerRadioButton.Checked = true; break;
                        case 1: TCP4VerRadioButton.Checked = true; break;
                        case 2: TCP6VerRadioButton.Checked = true; break;
                    }
                    
                    PrivKeyEdit.Text = reader.GetString(11);

                    EditAddCmd1.Text = reader.GetString(12);
                    EditAddCmd2.Text = reader.GetString(13);
                    EditAddCmd3.Text = reader.GetString(14);
                    EditAddCmd4.Text = reader.GetString(15);
                    EditAddCmd5.Text = reader.GetString(16);
                    EditAddCmd6.Text = reader.GetString(17);
                    EditAddCmd7.Text = reader.GetString(18);
                    EditAddCmd8.Text = reader.GetString(19);
                    EditAddCmd9.Text = reader.GetString(20);

                }
            } catch(SQLiteException e)
            {
                Our.log.LogAdd("Nie udało się odczytać definicji hosta " + id_host.ToString() + " : " + e.Message);
            }
        }

        private void LoadPrivKeyButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string privKeyPath = dialog.FileName;
                PrivKeyEdit.Text = File.ReadAllText(privKeyPath);
            }

        }

        private void ClearPrivKeyButton_Click(object sender, EventArgs e)
        {
            PrivKeyEdit.Clear();
        }

        private void FormHost_Shown(object sender, EventArgs e)
        {

        }
    }
}
