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
    public partial class Booking : Form
    {
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();

        string connectionString = @"Data Source=DESKTOP-PLBCBMJ;Initial Catalog=DivineNail;Integrated Security=True";

        private void Nail_Assistant_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nail_Assistant c1 = new Nail_Assistant();
            c1.ShowDialog();
            this.Show();
        }
                                                                                       

        private void Booking_Load(object sender, EventArgs e)
        {

            LoadDvg();

        }

        private void Create_Click(object sender, EventArgs e)
        {
           
                SqlConnection cnn = new SqlConnection(connectionString);
                string sql = "INSERT INTO Booking(Assistant_ID,Client_ID,Treatment_ID,Booking_Date,Booking_time,Booking_isAttended,Booking_isPayed) VALUES(@2,@3,@4,@5,@6,@7,@8)";
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@2", int.Parse(Cb2.Text));
                cmd.Parameters.AddWithValue("@3", int.Parse(Cb3.Text));
                cmd.Parameters.AddWithValue("@4", int.Parse(Cb4.Text));

                cmd.Parameters.AddWithValue("@5", dtp1.Text ); //2021/03/01
                cmd.Parameters.AddWithValue("@6", dtp.Text); //10:00:00

                cmd.Parameters.AddWithValue("@7", cBox1.Checked);
                cmd.Parameters.AddWithValue("@8", cBox2.Checked);
                cmd.ExecuteNonQuery();
                LoadDvg();
            try
            {
                cnn.Close();
            }
            catch
            {

                MessageBox.Show("!");
            }
        }

        private void Treatment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Treatment t1 = new Treatment();
            t1.ShowDialog();
            this.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection cnn = new SqlConnection(connectionString);
                string sql = "DELETE FROM Booking WHERE Booking_ID = '" + Cb1.Text + "'";
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@Booking_ID", Cb1.Text);
                cmd.ExecuteNonQuery();
                LoadDvg();
                cnn.Close();
            }
            catch
            {

                MessageBox.Show("!");
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            
                SqlConnection cnn = new SqlConnection(connectionString);
                string sql = "UPDATE Booking SET Assistant_ID=@2 ,Client_ID=@3 ,Treatment_ID=@4 ,Booking_Date=@5 ,Booking_Time=@6 ,Booking_isAttended=@7 ,Booking_isPayed=@8 Where Booking_ID = '" + Cb1.Text + "'";
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@2", int.Parse(Cb2.Text));
                cmd.Parameters.AddWithValue("@3", int.Parse(Cb3.Text));
                cmd.Parameters.AddWithValue("@4", int.Parse(Cb4.Text));

                
                cmd.Parameters.AddWithValue("@5",DateTime.Parse(dtp1.Text)); //2021/03/01
                cmd.Parameters.AddWithValue("@6",DateTime.Parse(dtp.Text+":00")); //10:00

                cmd.Parameters.AddWithValue("@7", cBox1.Checked);
                cmd.Parameters.AddWithValue("@8", cBox2.Checked);
                cmd.ExecuteNonQuery();
                LoadDvg();
                cnn.Close();

            try
            { }
            catch
            {
                
                MessageBox.Show("!");
            }
        }

        private void Cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                int i; 
                for (i = 0; i < Cb1.Items.Count; i++)
                    if (ds4.Tables[0].Rows[i][0].ToString() == Cb1.Text)
                    {
                        Cb1.Text = ds4.Tables[0].Rows[i][0].ToString();
                        Cb2.Text = ds4.Tables[0].Rows[i][1].ToString();
                        Cb3.Text = ds4.Tables[0].Rows[i][2].ToString();
                        Cb4.Text = ds4.Tables[0].Rows[i][3].ToString();

                        dtp1.Text = ds4.Tables[0].Rows[i][4].ToString();
                        dtp.Text = ds4.Tables[0].Rows[i][5].ToString().Substring(0,5);

                        cBox1.Checked = bool.Parse(ds4.Tables[0].Rows[i][6].ToString());
                        cBox2.Checked = bool.Parse(ds4.Tables[0].Rows[i][7].ToString());
                        break;
                    }

            try
            {
            }
            catch
            {

                MessageBox.Show("aa");
            }
        }

        private void Request_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report r1 = new Report();
            r1.ShowDialog();
            this.Show();
        }

        private void ConfPay_Click(object sender, EventArgs e)
        {

        }

        private void ConfAtt_Click(object sender, EventArgs e)
        {

        }

        private void Cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        public Booking()
        {
            InitializeComponent();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client c1 = new Client();
            c1.ShowDialog();
            this.Show();
        }

        public void LoadDvg()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(connectionString);

                string sql = "SELECT * FROM NailAss";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, cnn);
                SqlCommand command = new SqlCommand("SELECT Assistant_ID FROM NailAss; ", cnn);
                cnn.Open();
                ds1.Clear();
                adapter.Fill(ds1, "Info");
          
                SqlDataReader read = command.ExecuteReader();
                int i = 0;
                while (read.Read())
                {
                    if (!(Cb2.Items.Contains(ds1.Tables[0].Rows[i][0].ToString())))
                        Cb2.Items.Add(ds1.Tables[0].Rows[i][0].ToString());
                    i++;
                }

                Cb2.Text = (ds1.Tables[0].Rows[1][0].ToString());
                cnn.Close();

                sql = "SELECT * FROM Client";
                adapter = new SqlDataAdapter(sql, cnn);
                command = new SqlCommand("SELECT Client_ID FROM Client;", cnn);
                cnn.Open();
                ds2.Clear();
                adapter.Fill(ds2, "Info");

                 read = command.ExecuteReader();
                 i = 0;
                while (read.Read())
                {
                    if (!(Cb3.Items.Contains(ds2.Tables[0].Rows[i][0].ToString())))
                        Cb3.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
                    i++;
                }

                Cb3.Text = (ds2.Tables[0].Rows[1][0].ToString());
                cnn.Close();

                sql = "SELECT * FROM Treatment";
                adapter = new SqlDataAdapter(sql, cnn);
                command = new SqlCommand("SELECT Treatment_ID FROM Treatment ; ", cnn);
                cnn.Open();
                ds3.Clear();
                adapter.Fill(ds3, "Info");


                 read = command.ExecuteReader();
                 i = 0;
                while (read.Read())
                {
                    if (!(Cb4.Items.Contains(ds3.Tables[0].Rows[i][0].ToString())))
                        Cb4.Items.Add(ds3.Tables[0].Rows[i][0].ToString());
                    i++;
                }

                Cb4.Text = (ds3.Tables[0].Rows[1][0].ToString());

                 read.Close();
                cnn.Close();
                sql = "SELECT * FROM Booking";
                cnn = new SqlConnection(connectionString);
                adapter = new SqlDataAdapter(sql, cnn);
                command = new SqlCommand("select Booking_ID from Booking", cnn);
                cnn.Open();

                ds4.Clear();
                adapter.Fill(ds4, "Info");
                dvgB.DataSource = ds4.Tables[0];

                read = command.ExecuteReader();
                Cb1.Items.Clear();
                while (read.Read())
                {
                    Cb1.Items.Add(read["Booking_ID"].ToString());
                    Cb1.Text = (read["Booking_ID"].ToString());
                }
                read.Close();
                cnn.Close();


            
            }
            catch
            {

                MessageBox.Show("!");
            }

        }

        private void lblb_Click(object sender, EventArgs e)
        {
        }
    }
}
