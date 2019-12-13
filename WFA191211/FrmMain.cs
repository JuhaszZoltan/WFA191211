using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA191211
{
    public partial class FrmMain : Form
    {
        OleDbConnection conn;
        DateTime ma = new DateTime(2015, 10, 11);
        public FrmMain()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=utiroda.accdb");
            InitializeComponent();
            FillDgv();
            this.Icon = Properties.Resources.logo;
            lblMa.Text = ma.ToString("yyyy. MMMM dd.");
        }

        private void FillDgv()
        {
            dgvTurak.Rows.Clear();
            conn.Open();

            var cmd = new OleDbCommand(
                "SELECT T_KÓD, ÚTVONAL.HOVÁ, KEZDET, VÉGE, IDEGENVEZETŐ.NÉV, SZÁLLÁS.NÉV, ÁR " +
                "FROM (((TÚRA " +
                "INNER JOIN IDEGENVEZETŐ ON TÚRA.VEZETŐ = IDEGENVEZETŐ.I_KÓD) " +
                "INNER JOIN ÚTVONAL ON TÚRA.ÚTVONAL = ÚTVONAL.ÚT_KÓD) " +
                "INNER JOIN SZÁLLÁS ON TÚRA.SZÁLLÁS = SZÁLLÁS.SZ_KÓD) " +
                $"WHERE KEZDET > #{ma.ToString("yyyy-MM-")+"01"}#" +
                "GROUP BY T_KÓD, ÚTVONAL.HOVÁ, KEZDET, VÉGE, IDEGENVEZETŐ.NÉV, SZÁLLÁS.NÉV, ÁR " +
                "ORDER BY KEZDET ASC;", conn);

            var r = cmd.ExecuteReader();

            while (r.Read())
            {
                dgvTurak.Rows.Add(
                    r[0], r[1],
                    r.GetDateTime(2).ToString("yyyy.MM.dd."),
                    r.GetDateTime(3).ToString("yyyy.MM.dd."),
                    r[4], r[5], 
                    string.Format("{0:N0} ", int.Parse(r.GetString(6))));
            }

            conn.Close();
        }

        private void TsmiSzerkesztes_Click(object sender, EventArgs e)
        {
            var frm = new FrmUtas(conn);
            frm.ShowDialog();
        }

        private void TsmiKereses_Click(object sender, EventArgs e)
        {
            var frm = new FrmUtasLista();
            frm.ShowDialog();
        }
    }
}
