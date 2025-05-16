using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace Exportación_Información
{
    public partial class Inicio : Form
    {
        private string dbPath;
        private DataTable currentTable;
        public Inicio()
        {
            InitializeComponent();
        }
        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQLite Database (*.sqlite;*.db)|*.sqlite;*.db";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dbPath = ofd.FileName;
                LoadTables();
            }
        }

        private void LoadTables()
        {
            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();
                DataTable tables = conn.GetSchema("Tables");
                comboTables.Items.Clear();

                foreach (DataRow row in tables.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    comboTables.Items.Add(tableName);
                }

                conn.Close();
            }

            if (comboTables.Items.Count > 0)
                comboTables.SelectedIndex = 0;
        }

        private void comboTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = comboTables.SelectedItem.ToString();
            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();
                SQLiteDataAdapter da = new SQLiteDataAdapter($"SELECT * FROM {selectedTable}", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                currentTable = ds.Tables[0];
                dataGridView1.DataSource = currentTable;
                conn.Close();
            }
        }

        private void btnExportTXT_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataRow row in currentTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        sb.Append(item.ToString() + "\t");
                    }
                    sb.AppendLine();
                }
                File.WriteAllText(sfd.FileName, sb.ToString());
                MessageBox.Show("Exportado a TXT.");
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Files (*.csv)|*.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                
                for (int i = 0; i < currentTable.Columns.Count; i++)
                {
                    sb.Append(currentTable.Columns[i].ColumnName);
                    if (i < currentTable.Columns.Count - 1)
                        sb.Append(",");
                }
                sb.AppendLine();

                
                foreach (DataRow row in currentTable.Rows)
                {
                    for (int i = 0; i < currentTable.Columns.Count; i++)
                    {
                        sb.Append(row[i].ToString());
                        if (i < currentTable.Columns.Count - 1)
                            sb.Append(",");
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(sfd.FileName, sb.ToString());
                MessageBox.Show("Exportado a CSV.");
            }
        }

        private void btnExportXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML Files (*.xml)|*.xml";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                currentTable.WriteXml(sfd.FileName);
                MessageBox.Show("Exportado a XML.");
            }
        }
    }
}
