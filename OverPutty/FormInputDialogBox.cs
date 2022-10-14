using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverPutty
{
    public partial class InputDialoBox : Form
    {
        private ModalResult modalResult;

        public InputDialoBox()
        {
            InitializeComponent();
            textBox1.Text = "";
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
