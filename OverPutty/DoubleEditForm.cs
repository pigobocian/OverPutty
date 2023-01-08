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
    public partial class DoubleEditForm : Form
    {
        private ModalResult modalResult;
        private string text1;
        private string text2;   
        public DoubleEditForm(string title, string label1, string text1, string label2, string text2)
        {
            InitializeComponent();
            this.label1.Text = label1;
            this.textBox1.Text = text1;
            this.label2.Text = text2;
            this.textBox2.Text = text2;
            this.text1 = "";
            this.text2 = "";
            modalResult = new ModalResult();
        }

        private void buttonRezygnuj_Click(object sender, EventArgs e)
        {
            modalResult = ModalResult.mrCancel;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            modalResult= ModalResult.mrOK;
            text1 = textBox1.Text; 
            text2 = textBox2.Text;
            this.Close();
        }

        public string getText1()
        {
            return text1;
        }

        public string getText2()
        {
            return text2;
        }
    }
}
