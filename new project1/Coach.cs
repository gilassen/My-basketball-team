using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_project1
{
    public partial class Coach : Form
    {
        CreateCoach chForm = new CreateCoach();
       
        public Coach()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\97254\Desktop\new project1\Tables\ListPlayer1.mdf"";Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                con.Open();
                string listPlyer = "select * from Shooterplayer";
                SqlDataAdapter DA = new SqlDataAdapter(listPlyer, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(DA);
                var ds = new DataSet();
                DA.Fill(ds);
                ListPlayerS.DataSource = ds.Tables[0];

                string listPlyerC = "select * from PlayerCenter";
                SqlDataAdapter da = new SqlDataAdapter(listPlyerC, con);
                SqlCommandBuilder sqlCommandBuilder1 = new SqlCommandBuilder(da);
                var DS = new DataSet();
                da.Fill(DS);
                ListPlayerC.DataSource = DS.Tables[0];
                con.Close();
            }
            catch { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (IdC.Text == " ")
                MessageBox.Show("enter ID to delete player");
            else
            {
        
                {
                    con.Open();
                    string A = "delete from PlayerCenter where Idc = '" + IdC.Text + "';";
                    SqlCommand cmd = new SqlCommand(A, con);
                    cmd.ExecuteNonQuery();
                    string B = "delete from Shooterplayer where Ids = '" + IdC.Text + "';";
                    SqlCommand cmd1 = new SqlCommand(B, con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("delete successfully");
                    IdC.Clear();

                    con.Close();
                    populate();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chForm = new CreateCoach();
            try
            {
                chForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void PrsentPlayer_Click(object sender, EventArgs e)
        {

        }

        private void Coach_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ListPlayerS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IdC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
