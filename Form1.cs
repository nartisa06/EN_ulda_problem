using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using MetroFramework.Components;

namespace EN_ulda_problem_23012024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void b_aprekinat_Click(object sender, EventArgs e)
        {

            double ladites_platums = 0;
            double ladites_garums = 0;
            double ladites_augstums = 0;
            int pvn = 21;
            int darba_samaksa = 15;
            string vards = " ";
            string velejums = " ";
            double kokmateriala_cena = 0;
          

            if (tb_ladites_platums.Text == "" || tb_ladites_platums.Text == " " || tb_ladites_platums.Text == null)
            {

                MessageBox.Show("Ievadiet ludzu lodītes platumu");
            }
            else
            {
                ladites_platums = System.Convert.ToDouble(tb_ladites_platums.Text);
            }
            if (tb_ladites_garums.Text == "" || tb_ladites_garums.Text == " " || tb_ladites_garums.Text == null)
            {

                MessageBox.Show("Ievadiet ludzu lodītes garumu");
            }
            else
            {
                ladites_garums = System.Convert.ToDouble(tb_ladites_garums.Text);
            }
            if (tb_augstums.Text == "" || tb_augstums.Text == " " || tb_augstums.Text == null)
            {

                MessageBox.Show("Ievadiet ludzu lodītes platumu");
            }
            else
            {
                ladites_augstums= System.Convert.ToDouble(tb_augstums.Text);
            }
            if (nud_kokmateriala_Cena.Value == 0 || nud_kokmateriala_Cena.Text == null)

            {

                MessageBox.Show("Ievadiet ludzu kokmateriāla cenu");
            }
            else
            {
                kokmateriala_cena = System.Convert.ToDouble(nud_kokmateriala_Cena.Value);
            }
            if (tb_vards.Text == "" || tb_vards.Text == " " || tb_vards.Text == null)
            {

                MessageBox.Show("Ievadiet ludzu vārdu");
            }
            else
            {
                vards = System.Convert.ToString(tb_vards.Text);
            }
            if (tb_veltijums.Text == "" || tb_veltijums.Text == " " || tb_veltijums.Text == null)
            {

                MessageBox.Show("Ievadiet ludzu vēlējumu");
            }
            else
            {
                velejums = System.Convert.ToString(tb_veltijums.Text);
            }

            int gar = velejums.Length;
            double vel_garums = gar * 1.2;

            double produkta_cena = ((vel_garums) + (((ladites_platums / 100) * (ladites_garums /100) * (ladites_augstums / 100))/ 3) * kokmateriala_cena);
            double p_cena = ((vel_garums) + (((ladites_platums / 100) * (ladites_garums / 100) * (ladites_augstums / 100)) / 3) * kokmateriala_cena);
            double PVN_summa = (produkta_cena + darba_samaksa) * pvn / 100;
            double rekina_summa = (produkta_cena + darba_samaksa) + PVN_summa;

            rtb_rekins.Text = $"Produkta cena: {produkta_cena:C}\n" +
                                   $"PVN summa: {PVN_summa:C}\n" +
                                   $"Rekina summa: {rekina_summa:C}\n";
            tb_rekins.Text = rekina_summa.ToString();

            
            
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreatConnection();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO Ulda_izmaksas(Klienta_vards, Velejums, Ladites_garums, Ladites_platums, ladites_augstums, kokmateriala_cena) VALUES('" + tb_vards.Text + "','" + tb_veltijums.Text + "','" + tb_ladites_garums.Text + "','" + tb_ladites_platums.Text + "', '" + tb_augstums.Text + "','" + nud_kokmateriala_Cena.Text + "');";
                sqlite_cmd.ExecuteNonQuery();
            
           
        }
        
        
            static SQLiteConnection CreatConnection()
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = new SQLiteConnection("Data Source=ulda_problem.db; Version = 3; New = True; Compress = True; ");
                try
                {
                    sqlite_conn.Open();
                }
                catch (Exception ex)
                {

                }
                return sqlite_conn;
            }

        private void b_dzest_Click(object sender, EventArgs e)
        {
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreatConnection();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "DELETE FROM ulda_izmaksas WHERE id=" + tb_dzest_id.Text + ";";
                sqlite_cmd.ExecuteNonQuery();
                tb_dzest_id.Clear();
            }
        }

        private void b_apskatit_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreatConnection();

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Ulda_izmaksas";

            DataTable sTable;
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
            using (sTable = new DataTable())
            {
               sqlda.Fill(sTable);
                dgv_apskatit.DataSource = sTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
                {
                    StreamWriter a = new StreamWriter("Rekins.txt");

                    a.WriteLine(label2.Text + " " + tb_vards.Text);
                    a.WriteLine(label3.Text + " " + tb_veltijums.Text);
                    a.WriteLine(label4.Text + " " + tb_ladites_platums.Text);
                    a.WriteLine(label5.Text + " " + tb_ladites_garums.Text);
                    a.WriteLine(label6.Text + " " + tb_augstums.Text);
                    a.WriteLine(label7.Text + " " + nud_kokmateriala_Cena.Value);

                    

                    a.Close();

            
            }

        private void tb_rekina_izveide_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
