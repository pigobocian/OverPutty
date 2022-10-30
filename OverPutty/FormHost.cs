using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace OverPutty
{
    public partial class FormHost : Form
    {
        
        int id_hostGroup = 0;
        string hostGroupName = "";
        string privKeyPath = "";

        public FormHost()
        {
            InitializeComponent();
        }

        public FormHost(string caption, string groupName, int id_hostGroup)
        {
            InitializeComponent();
            this.Text = caption;
            GroupInfoLabel.Text = groupName;
            hostGroupName = groupName;
            this.id_hostGroup = id_hostGroup;
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
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
        }


        private void AddHost()
        {
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

            bool privKey = PrivKeyCheckBox.Checked;

            string addCmd1 = EditAddCmd1.Text;
            string addCmd2 = EditAddCmd2.Text;
            string addCmd3 = EditAddCmd3.Text;
            string addCmd4 = EditAddCmd4.Text;
            string addCmd5 = EditAddCmd5.Text;
            string addCmd6 = EditAddCmd6.Text;
            string addCmd7 = EditAddCmd7.Text;
            string addCmd8 = EditAddCmd8.Text;
            string addCmd9 = EditAddCmd9.Text;

        }

        private void SelectPrivKeyFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All files (*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                privKeyPath = dialog.FileName;
                PrivKeyCheckBox.Checked = true;
                PrivKeyFilePathLabel.Text = privKeyPath;
            } 
        }
    }
}
