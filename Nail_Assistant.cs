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
    public partial class Nail_Assistant : Form
    {



        DataSet ds = new DataSet(); 
        string connectionString = @"Data Source=DESKTOP-PLBCBMJ;Initial Catalog=DivineNail;Integrated Security=True";



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Nail_Assistant()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(connectionString);
                string sql = "DELETE FROM NailAss WHERE Assistant_ID = '" + Cb1.Text + "'";
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@Assistant_ID", Cb1.Text);
                cmd.ExecuteNonQuery();
                LoadDvg();
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("!");

            }
        }

        private void Create_Click(object sender, EventArgs e)
        {

            try
            {
                if (!tb1.Text.All(char.IsLetter))
                    ep1.SetError(tb1, "Must only be letters");
                else if (!tb2.Text.All(char.IsLetter))
                    ep1.SetError(tb2, "Must only be letters");
                else if (!tb3.Text.All(char.IsDigit))
                    ep1.SetError(tb3, "The Number Must be inputted in the form ##########");
                else if (!(tb3.Text.Length == 10))
                    ep1.SetError(tb3, "The Number Must be inputted in the form ##########");
                else
                {
                    SqlConnection cnn = new SqlConnection(connectionString);
                    string sql = "INSERT INTO NailAss(First_Name,Last_Name,Contact_Num) VALUES(@2,@3,@4)";
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cnn);
                    cmd.Parameters.AddWithValue("@2", tb1.Text);
                    cmd.Parameters.AddWithValue("@3", tb2.Text);
                    cmd.Parameters.AddWithValue("@4", tb3.Text);
                    cmd.ExecuteNonQuery();
                    LoadDvg();
                    cnn.Close();
                }
            }
            catch
            {
                MessageBox.Show("!");
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tb1.Text.All(char.IsLetter))
                    ep1.SetError(tb1, "Must only be letters");
                else if (!tb2.Text.All(char.IsLetter))
                    ep1.SetError(tb2, "Must only be letters");
                else if (!tb3.Text.All(char.IsDigit))
                    ep1.SetError(tb3, "The Number Must be inputted in the form ##########");
                else if (!(tb3.Text.Length == 10))
                    ep1.SetError(tb3, "The Number Must be inputted in the form ##########");
                else
                {
                    SqlConnection cnn = new SqlConnection(connectionString);
                    string sql = "UPDATE NailAss SET First_Name=@2 ,Last_Name=@3 ,Contact_Num=@4  Where Assistant_ID = '" + Cb1.Text + "'";
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cnn);
                    cmd.Parameters.AddWithValue("@2", tb1.Text);
                    cmd.Parameters.AddWithValue("@3", tb2.Text);
                    cmd.ExecuteNonQuery();
                    LoadDvg();
                    cnn.Close();
                }
            }
            catch
            {

                MessageBox.Show("!");
            }
        }

        private void Cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                for (i = 0; i < Cb1.Items.Count; i++)
                    if (ds.Tables[0].Rows[i][0].ToString() == Cb1.Text)
                    {
                        tb1.Text = ds.Tables[0].Rows[i][1].ToString();
                        tb2.Text = ds.Tables[0].Rows[i][2].ToString();
                        tb3.Text = ds.Tables[0].Rows[i][3].ToString();
                        break;
                    }
            }
            catch
            {

                MessageBox.Show("aaa");
            }

        }

        private void Nail_Assistant_Load(object sender, EventArgs e)
        {
            LoadDvg();
        }
        public void LoadDvg()
        {
            string sql = "SELECT * FROM NailAss";
            try
            {
                

                SqlConnection cnn = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, cnn);
                SqlCommand command = new SqlCommand("select Assistant_ID from NailAss", cnn);
                ds.Clear();
                cnn.Open();

                adapter.Fill(ds, "Info");
                dvgN.DataSource = ds.Tables[0];

                SqlDataReader read = command.ExecuteReader();
                Cb1.Items.Clear();
                while (read.Read())
                {
                    Cb1.Items.Add(read["Assistant_ID"].ToString());
                    Cb1.Text = (read["Assistant_ID"].ToString());

                }
                read.Close();
                cnn.Close();
            }
            catch
            {

            }

        }
    }
}
