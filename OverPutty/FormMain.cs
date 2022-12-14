using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OverPutty
{

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Common.log.LogAdd("Start aplikacji");
            RefreshGrupyListBox();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ConfigForm form = new ConfigForm();
            form.ShowDialog();
        }

        private void DodajGrupyClick(object sender, EventArgs e)
        {
            InputDialogBox dialog = new InputDialogBox();
            dialog.ShowDialog();

            if (dialog.getModalResult() == ModalResult.mrOK)
            {
                string txt = dialog.getText();
                

                RefreshGrupyListBox();
            }
        }

        private void RefreshGrupyListBox()
        {
            //Dictionary<int, string> grupy = Common.db.getGroupList();

            listBoxGrupy.Items.Clear();

            //foreach (var entry in grupy)
            //{
            //    ListBoxElement lbItem = new ListBoxElement(entry.Key, entry.Value);
            //    listBoxGrupy.Items.Add(lbItem);
            //}
        }

        //private void Refresh
        
        private void EdytujGrupyClick(object sender, EventArgs e)
        {
            ListBoxElement element = (ListBoxElement)listBoxGrupy.SelectedItem;

            if (element != null)
            {
                int id_grupy = element.getId();
                string nazwa = element.getText();

                InputDialogBox box = new InputDialogBox(nazwa, true);
                box.ShowDialog();
                if (box.getModalResult() == ModalResult.mrOK)
                {
                    nazwa = box.getText();
                    //Common.db.UpdateGroup(id_grupy, nazwa);
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

                InputDialogBox box = new InputDialogBox("Czy usunąć grupę ? ( " + nazwa + " )", false);
                box.ShowDialog();

                if (box.getModalResult() == ModalResult.mrOK)
                {
            //        Common.db.DeleteGroup(id_grupy);
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

            int id_hostGroup = grupa.getId();
            string groupName = grupa.getText();

            //FormHost box = new FormHost("Nowy host", groupName, id_hostGroup);
            //box.ShowDialog();


        }
    }

    static class Common
    {
        public const int languagePolish = 1;
        public const int languageEnglish = 2;

        public static int selectedLanguage = languagePolish;

        public static Log log = new Log();
        public static DBInterface db = new DBInterface();
    }

    public enum ModalResult
    {
        mrOK, mrCancel
    }

}
