using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Divine_Nail
{
    public partial class Client : Form
    {

        DataSet ds = new DataSet();
        string connectionString = @"Data Source=DESKTOP-PLBCBMJ;Initial Catalog=DivineNail;Integrated Security=True";



        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        public Client()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
        }

        private void Create_Click(object sender, EventArgs e)
        {

           
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            
        }

        private void Cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Client_Load_1(object sender, EventArgs e)
        {
            LoadDvg();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tba.Text.All(char.IsLetter))
                    ep1.SetError(tba, "Must only be letters");
                else if (!tbb.Text.All(char.IsLetter))
                   ep1.SetError(tbb, "Must only be letters");
                else if(!tbc.Text.All(char.IsDigit))
                    ep1.SetError(tbc, "The Number Must be inputted in the form ##########");
                else if (!(tbc.Text.Length == 10))
                    ep1.SetError(tbc, "The Number Must be inputted in the form ##########");
                else
                {
                    SqlConnection cnn = new SqlConnection(connectionString);
                    string sql = "INSERT INTO Client(First_Name,Last_Name,Contact_Num) VALUES(@2,@3,@4)";
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cnn);
                    cmd.Parameters.AddWithValue("@2", tba.Text);
                    cmd.Parameters.AddWithValue("@3", tbb.Text);
                    cmd.Parameters.AddWithValue("@4", tbc.Text);
                    cmd.ExecuteNonQuery();
                    LoadDvg();
                    cnn.Close();
                }
            }
            catch
            {

                MessageBox.Show("a");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tba.Text.All(char.IsLetter))
                    ep1.SetError(tba, "Must only be letters");
                else if (!tbb.Text.All(char.IsLetter))
                    ep1.SetError(tbb, "Must only be letters");
                else if (!tbc.Text.All(char.IsDigit))
                    ep1.SetError(tbc, "The Number Must be inputted in the form ##########");
                else if (!(tbc.Text.Length == 10))
                    ep1.SetError(tbc, "The Number Must be inputted in the form ##########");
                else
                {
                    SqlConnection cnn = new SqlConnection(connectionString);
                    string sql = "UPDATE Client SET First_Name=@2 ,Last_Name=@3 ,Contact_Num=@4 Where Client_ID = '" + cba.Text + "'";
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cnn);
                    cmd.Parameters.AddWithValue("@2", tba.Text);
                    cmd.Parameters.AddWithValue("@3", tbb.Text);
                    cmd.Parameters.AddWithValue("@4", tbc.Text);
                    cmd.ExecuteNonQuery();
                    LoadDvg();
                    cnn.Close();
                }
            }
            catch
            {

                MessageBox.Show("b");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {

                SqlConnection cnn = new SqlConnection(connectionString);
                string sql = "DELETE FROM Client WHERE Client_ID = '" + cba.Text + "'";
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@Client_ID", cba.Text);
                cmd.ExecuteNonQuery();
                LoadDvg();
                cnn.Close();
            }
            catch
            {

                MessageBox.Show("c");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void cba_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            
                int i; 
                for (i = 0; i < cba.Items.Count; i++)
                    if (ds.Tables[0].Rows[i][0].ToString() == cba.Text)
                    {
                        tba.Text = ds.Tables[0].Rows[i][1].ToString();
                        tbb.Text = ds.Tables[0].Rows[i][2].ToString();
                        tbc.Text = ds.Tables[0].Rows[i][3].ToString();
                        break;
                    }
            }
            catch
            {

                MessageBox.Show("aaa");
            }

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {
           

        }
        public void LoadDvg()
        {
            try
            {
                string sql = "SELECT * FROM Client";
                SqlConnection cnn = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, cnn);
                SqlCommand command = new SqlCommand("select Client_ID from Client", cnn);
                cnn.Open();

                ds.Clear();
                adapter.Fill(ds, "Info");
                dgv1.DataSource = ds.Tables[0];


            
                SqlDataReader read = command.ExecuteReader();
           
                cba.Items.Clear();
                while (read.Read())
                {
                    cba.Items.Add(read["Client_ID"].ToString());
                    cba.Text = (read["Client_ID"].ToString());
                }
            
                read.Close();
                cnn.Close();
            }
            catch
            {
                
                MessageBox.Show("d");
            }

        }
    }
}
