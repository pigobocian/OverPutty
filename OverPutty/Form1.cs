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
            refreshGrupyListBox();
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void dodajClick(object sender, EventArgs e)
        {
            InputDialoBox dialog = new InputDialoBox();
            dialog.ShowDialog();
            if(dialog.getResult() == ModalResult.mrOK)
            {
                string txt = dialog.getText();
                Our.db.AddGrupa(txt);

                refreshGrupyListBox();
            }
        }

        private void refreshGrupyListBox()
        {
            Dictionary<int, string> grupy = Our.db.getListaGrup();

            listBoxGrupy.Items.Clear();

            foreach(var entry in grupy)
            {
                ListBoxElement lbItem = new ListBoxElement(entry.Key, entry.Value);
                listBoxGrupy.Items.Add(lbItem);
            }
        }

        private void edytujClick(object sender, EventArgs e)
        {
            ListBoxElement element = (ListBoxElement)listBoxGrupy.SelectedItem;

            int id_grupy = element.getId();
            string nazwa = element.getText();

            InputDialoBox box = new InputDialoBox(nazwa);
            box.ShowDialog();
            if(box.getResult() == ModalResult.mrOK)
            {
                nazwa = box.getText();  
                Our.db.UpadteGrupy(id_grupy, nazwa);
                refreshGrupyListBox();
            }

        }
    }

    static class Our
    {
        public static Log log = new Log();
        public static DBInterface db = new DBInterface();
    }

}
