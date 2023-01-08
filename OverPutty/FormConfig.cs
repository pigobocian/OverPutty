using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace OverPutty
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void buttonUslugiDodaj_Click(object sender, System.EventArgs e)
        {
            InputDialogBox box = new InputDialogBox();
            if(box.ShowDialog() == DialogResult.OK)
            {
                string sql = "insert into ";
                SQLiteCommand cmd = new SQLiteCommand();
            }
        }

        private void buttonEdytujUslugi_Click(object sender, System.EventArgs e)
        {
            InputDialogBox box = new InputDialogBox("edit", true);
            if(box.ShowDialog() == DialogResult.OK)
            {
                string sql = "update";
                SQLiteCommand cmd = new SQLiteCommand();
            }
        }

        private void buttonDodajSlowniki_Click(object sender, System.EventArgs e)
        {
            InputDialogBox box = new InputDialogBox();
            if (box.ShowDialog() == DialogResult.OK)
            {
                string sql = "insert into ";
                SQLiteCommand cmd = new SQLiteCommand();
            }
        }

        private void buttonEdytujSlowniki_Click(object sender, System.EventArgs e)
        {
            InputDialogBox box = new InputDialogBox("edit", true);
            if (box.ShowDialog() == DialogResult.OK)
            {
                string sql = "update";
                SQLiteCommand cmd = new SQLiteCommand();
            }
        }

        private void buttonDodajCechy_Click(object sender, System.EventArgs e)
        {
            InputDialogBox box = new InputDialogBox();
            if (box.ShowDialog() == DialogResult.OK)
            {
                string sql = "insert into ";
                SQLiteCommand cmd = new SQLiteCommand();
            }
        }

        private void buttonEdytujCechy_Click(object sender, System.EventArgs e)
        {
            InputDialogBox box = new InputDialogBox("edit", true);
            if (box.ShowDialog() == DialogResult.OK)
            {
                string sql = "update";
                SQLiteCommand cmd = new SQLiteCommand();
            }
        }

        private void buttonDatabaseFileSelect_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog box = new OpenFileDialog();
            box.Filter = "Pliki tekstowe|*.txt|Pliki baz Firebird|*.fb;*.gdb";
            box.FilterIndex = 2;
            box.RestoreDirectory = true;
            if (box.ShowDialog() == DialogResult.OK)
            {
                textBoxDatabase.Text = box.FileName;      
            }
        }
    }
}
