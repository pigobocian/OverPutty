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
        private enum ModalResult
        {
            mrOK, mrCancel
        }
        private ModalResult modalResult;

        public InputDialoBox()
        {
            InitializeComponent();
        }

        private void InputDialogBox_Load(object sender, EventArgs e)
        {

        }

        private void buttonRezygnujClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
