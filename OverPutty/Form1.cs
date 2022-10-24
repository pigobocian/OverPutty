using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace OverPutty
{

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Our.log.LogAdd("Start aplikacji");
            RefreshGrupyListBox();
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void DodajGrupyClick(object sender, EventArgs e)
        {
            InputDialogBox dialog = new InputDialogBox();
            dialog.ShowDialog();

            if (dialog.getResult() == ModalResult.mrOK)
            {
                string txt = dialog.getText();
                Our.db.AddGrupa(txt);

                RefreshGrupyListBox();
            }
        }

        private void RefreshGrupyListBox()
        {
            Dictionary<int, string> grupy = Our.db.getListaGrup();

            listBoxGrupy.Items.Clear();

            foreach (var entry in grupy)
            {
                ListBoxElement lbItem = new ListBoxElement(entry.Key, entry.Value);
                listBoxGrupy.Items.Add(lbItem);
            }
        }

        private void EdytujGrupyClick(object sender, EventArgs e)
        {
            ListBoxElement element = (ListBoxElement)listBoxGrupy.SelectedItem;

            if (element != null)
            {
                int id_grupy = element.getId();
                string nazwa = element.getText();

                InputDialogBox box = new InputDialogBox(nazwa, true);
                box.ShowDialog();
                if (box.getResult() == ModalResult.mrOK)
                {
                    nazwa = box.getText();
                    Our.db.UpadteGrupy(id_grupy, nazwa);
                    RefreshGrupyListBox();
                }
            }
        }

        private void DeleteGrupyClick(object sender, EventArgs e)
        {
            ListBoxElement element = (ListBoxElement)listBoxGrupy.SelectedItem;

            if (element != null)
            {
                int id_grupy = element.getId();
                string nazwa = element.getText();

                InputDialogBox box = new InputDialogBox("Czy usunąć grupę ? ( "+nazwa+" )", false);
                box.ShowDialog();

                if (box.getResult() == ModalResult.mrOK)
                {
                    Our.db.DeleteGrupy(id_grupy);
                    RefreshGrupyListBox();
                }
            }
        }

        private void DodajHostClick(object sender, EventArgs e)
        {
            ListBoxElement grupa = (ListBoxElement)listBoxGrupy.SelectedItem;
            if (grupa == null)
            {
                MessageBox.Show("Wybierz proszę najpierw grupę !");
                return;
            }

            InputDialogBox box = new InputDialogBox();
            box.ShowDialog();

            if (box.getResult() == ModalResult.mrOK)
            {
                int id_grupy = grupa.getId();

                
            }

        }
    }

    static class Our
    {
        public static Log log = new Log();
        public static DBInterface db = new DBInterface();
    }

}
