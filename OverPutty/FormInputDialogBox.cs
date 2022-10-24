using System;
using System.Windows.Forms;

namespace OverPutty
{
    public partial class InputDialogBox : Form
    {
        private ModalResult modalResult;

        public InputDialogBox()
        {
            InitializeComponent();
            textBox1.Text = "";
            textBox1.Visible = true;
            label1.Visible = false;
        }

        public InputDialogBox(string text, bool isEdit)
        {
            InitializeComponent();

            if (isEdit)
            {
                textBox1.Text = text;
                textBox1.Visible = true;
                label1.Visible = false;
            }
            else
            {
                textBox1.Text = "";
                textBox1.Visible = false;
                label1.Visible = true;
                label1.Text = text;
            }
        }


        private void InputDialogBox_Load(object sender, EventArgs e)
        {

        }

        private void buttonRezygnujClick(object sender, EventArgs e)
        {
            modalResult = ModalResult.mrCancel;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            modalResult = ModalResult.mrOK;
            this.Close();
        }

        public string getText()
        {
            return textBox1.Text;
        }

        public ModalResult getResult()
        {
            return modalResult;
        }
    }

    public enum ModalResult
    {
        mrOK, mrCancel
    }

}
