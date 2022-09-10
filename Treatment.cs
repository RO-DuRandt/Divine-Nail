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
    public partial class Treatment : Form
    {

        DataSet ds = new DataSet();
        string connectionString = @"Data Source=DESKTOP-PLBCBMJ;Initial Catalog=DivineNail;Integrated Security=True";


        public Treatment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(Double.TryParse(tb2.Text,out double d)))
                    ep1.SetError(tb2, "Must only a number in the format ##,###");
                else
                {
                    SqlConnection cnn = new SqlConnection(connectionString);
                    string sql = "INSERT INTO Treatment(Treatment_Description,Treatment_Price) VALUES(@2,@3)";
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cnn);
                    cmd.Parameters.AddWithValue("@2", tb1.Text);
                    cmd.Parameters.AddWithValue("@3", tb2.Text.Replace(',', '.'));
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

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tb2.Text.All(char.IsLetter))
                    ep1.SetError(tb2, "Must only a number in the format ##,###");
                else
                {
                    SqlConnection cnn = new SqlConnection(connectionString);
                    string sql = "UPDATE Treatment SET Treatment_Description=@2 ,Treatment_Price=@3 Where Treatment_ID = '" + Cb1.Text + "'";
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cnn);
                    cmd.Parameters.AddWithValue("@2", tb1.Text);
                    cmd.Parameters.AddWithValue("@3", tb2.Text.Replace(',', '.'));
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

        private void Delete_Click(object sender, EventArgs e)
        {
                SqlConnection cnn = new SqlConnection(connectionString);
                string sql = "DELETE FROM Treatment WHERE Treatment_ID = '" + Cb1.Text + "'";
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@Treatment_ID", Cb1.Text);
                cmd.ExecuteNonQuery();
                LoadDvg();
                cnn.Close();
            try
            { }
            catch
            {

                MessageBox.Show("c");
            }
        }

        private void Treatment_Load(object sender, EventArgs e)
        {
            LoadDvg();

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
                        break;
                    }
            }
            catch
            {

                MessageBox.Show("aaa");
            }
        }

        public void LoadDvg()
        {

           
          try
            {
                string sql = "SELECT * FROM Treatment";
                SqlConnection cnn = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, cnn);
                SqlCommand command = new SqlCommand("select Treatment_ID from Treatment", cnn);
                ds.Clear();
                cnn.Open();

                adapter.Fill(ds, "Info");
                dvgT.DataSource = ds.Tables[0];

                SqlDataReader read = command.ExecuteReader();
                Cb1.Items.Clear();
                while (read.Read())
                {
                    Cb1.Items.Add(read["Treatment_ID"].ToString());
                    Cb1.Text = (read["Treatment_ID"].ToString());
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
