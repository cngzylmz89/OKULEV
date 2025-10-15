using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;

namespace PERFORMANS
{
    public partial class frmogretmendurum : Form
    {
        public frmogretmendurum()
        {
            InitializeComponent();
        }
        baglantisinif conn=new baglantisinif();
        private void frmogretmendurum_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(conn.baglan);
            con.Open();
            OleDbCommand komutogretmendurum = new OleDbCommand("select DISTINCT ADISOYADI, count(OGRETMEN) AS 'PUANLANMIŞ DERS SAYISI' FROM TBLDERSPROGRAMI INNER JOIN TBLOGRETMENLER ON TBLOGRETMENLER.OGRETMENID=TBLDERSPROGRAMI.OGRETMEN WHERE OLCDURUM=1  GROUP BY ADISOYADI ORDER BY count(OGRETMEN) DESC", con);
            OleDbDataAdapter da=new OleDbDataAdapter(komutogretmendurum);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        int ogretmenid;
        string ogretmenintc;
        public string sifrele(string s)
        {
            byte[] sdizi = ASCIIEncoding.ASCII.GetBytes(s);
            string sifreli = Convert.ToBase64String(sdizi);
            return sifreli;
        }

        public string sifrecoz(string s)
        {
            byte[] sdizi = Convert.FromBase64String(s);
            string sifresiz = ASCIIEncoding.ASCII.GetString(sdizi);
            return sifresiz;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbConnection con = new OleDbConnection(conn.baglan);
            con.Open();
            OleDbCommand komutogretmentcoku=new OleDbCommand("select OGRETMENID from TBLOGRETMENLER where ADISOYADI='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
            OleDbDataReader dr = komutogretmentcoku.ExecuteReader();
            if (dr.Read())
            {
                 ogretmenid= int.Parse(dr["OGRETMENID"].ToString());
            }
            con.Close();
            con.Open();
            OleDbCommand ogretmentcbul=new OleDbCommand("select TCKIMLIKNO FROM TBLOGRETMENLER where OGRETMENID="+ogretmenid+"",con);
            OleDbDataReader dr2 = ogretmentcbul.ExecuteReader();
            if (dr2.Read())
            {
                ogretmenintc = dr2[0].ToString();

            }
            frmdersprogrami drp = new frmdersprogrami();
            drp.ogretmentc = sifrecoz(ogretmenintc);
            drp.rolum = "yonetici";
            drp.Show();



        }
    }
}
