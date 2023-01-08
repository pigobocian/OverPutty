using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace OverPutty
{
    public partial class FormHost : Form
    {
        


        public void ClearForm()
        {
        }

        public void LoadFormFromDB(int id_host)
        {
            ClearForm();

            try
            {
                string sql = "";

                SQLiteCommand cmd = new SQLiteCommand(sql, Common.db.GetConnection());
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string hostName = reader.GetString(2);
                    int port = reader.GetInt32(3);
                    string host = reader.GetString(4);
                    bool compress = reader.GetBoolean(7);
                }
            } catch(SQLiteException e)
            {
                Common.log.LogAdd("Nie udało się odczytać definicji hosta " + id_host.ToString() + " : " + e.Message);
            }
        }

        private void LoadPrivKeyButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
            }

        }

        private void FormHost_Load(object sender, EventArgs e)
        {

        }
    }
}
