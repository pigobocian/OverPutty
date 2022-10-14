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
 
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Our.log.LogAdd("Start aplikacji");
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputDialoBox dialog = new InputDialoBox();
            dialog.ShowDialog();
            if(dialog.getResult() == ModalResult.mrOK)
            {
                string txt = dialog.getText();
                int id = Our.db.AddGrupa(txt);
                if (id != 0)
                {
                    ListBoxElement buf = new ListBoxElement(11101, txt);
                    listBoxGrupy.Items.Add(buf);
                } else
                {
                    MessageBox.Show("Nie udało się dodać nowej grupy");
                }
                    
                
            }
        }
    }

    static class Our
    {
        public static Log log = new Log();
        public static DBInterface db = new DBInterface();
    }

}
