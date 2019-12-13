using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WFA191211
{
    public partial class FrmUtas : Form
    {
        OleDbConnection conn;
        DateTime ma = new DateTime(2015, 10, 11);
        public FrmUtas(OleDbConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            this.Icon = Properties.Resources.utas;
            FillCb();
        }

        private void FillCb()
        {
            conn.Open();
            var cmd = new OleDbCommand(
                "SELECT T_KÓD FROM TÚRA " +
                $"WHERE KEZDET >= #{ma.ToString("yyyy-MM-") + "01"}#;",
                conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                cbJelentkezes.Items.Add(r[0]);
            }
            conn.Close();
        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmUtasLista();
            frm.ShowDialog();
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbKod.Text))
            {
                //INSERET
                if(string.IsNullOrWhiteSpace(tbNev.Text))
                {
                    MessageBox.Show("A 'NÉV' mező kitöltése kötelező!");
                }

                else if(string.IsNullOrWhiteSpace(rtbCim.Text))
                {
                    MessageBox.Show("A 'CÍM' mező kitöltése kötelező!");
                }
                else
                {
                    conn.Open();

                    string jel = cbJelentkezes.SelectedIndex == -1 
                        ? "NULL" 
                        : cbJelentkezes.SelectedItem.ToString();

                    var adapter = new OleDbDataAdapter()
                    {
                        InsertCommand = new OleDbCommand(
                            "INSERT INTO UTAS (NÉV, CÍM, JELENTKEZIK) VALUES " + 
                            $"('{tbNev.Text}', '{rtbCim.Text}', {jel});", conn)
                    };
                    adapter.InsertCommand.ExecuteNonQuery();

                    var cmd = new OleDbCommand("SELECT MAX(U_KÓD) FROM UTAS;", conn);
                    var r = cmd.ExecuteReader();
                    r.Read();
                    tbKod.Text = r[0].ToString();
                    
                    conn.Close();
                }
            }
            else
            {
                //UPDATE
            }
            
            
        }

        private void tsmiTorles_Click(object sender, EventArgs e)
        {
            var valasz = MessageBox.Show(
                "Biztosan törölni szeretnéd a rekordot?",
                "TÖRLÉS",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if(valasz == DialogResult.Yes)
            {
                //DELETE


                MessageBox.Show("Adatok törölve!");
                tbKod.Text = "";
                tbNev.Text = "";
                rtbCim.Text = "";
                tsmiTorles.Enabled = false;
            }
        }

        private void tbKod_TextChanged(object sender, EventArgs e)
        {
            tsmiTorles.Enabled = !string.IsNullOrWhiteSpace(tbKod.Text);
        }
    }
}
