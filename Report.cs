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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        string connectionString = @"Data Source=DESKTOP-PLBCBMJ;Initial Catalog=DivineNail;Integrated Security=True";


        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb7.Text == "Date")
            {
                dtpD1.Visible = true;
                dtpD2.Visible = true;
                btnCI.Visible = true;
                lbl1.Visible = true;
                lbl2.Visible = true;
                cbD.Visible = true;

            }
            else if (cb7.Text == "Off")
            {
                dtpD1.Visible = false;
                dtpD2.Visible = false;
                btnCI.Visible = false;
                lbl1.Visible = false;
                lbl2.Visible = false;
                cbD.Visible = false;
                cbD.Checked = false;
            }
            LoadDvg();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb6.Text == "Attended/Payed")
            {
                cba.Visible = true;
                cbp.Visible = true;
                cbC.Visible = true;

            }
            else if (cb6.Text == "Payed")
            {
                cba.Visible = false;
                cbp.Visible = true;
                cbC.Visible = true;
            }
            else if (cb6.Text == "Attended")
            {
                cba.Visible = true;
                cbp.Visible = false;
                cbC.Visible = true;
            }
            else if (cb6.Text == "Off")
            {
                cba.Visible = false;
                cbp.Visible = false;
                cbC.Visible = false;
                cbC.Checked = false;
            }
            LoadDvg();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb5.Text == "Time")
            {
                dtpT1.Visible = true;
                dtpT2.Visible = true;
                lblT.Visible = true;
                lblF.Visible = true;
                cbT.Visible = true;

            }
            else if (cb5.Text == "Off")
            {
                dtpT1.Visible = false;
                dtpT2.Visible = false;
                lblT.Visible = false;
                lblF.Visible = false;
                cbT.Visible = false;
                cbT.Checked = false;
            }
            LoadDvg();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb5.Text = "Off";
            cb6.Text = "Off";
            cb7.Text = "Off";

            if (cb1.Text == "Booking_ID")
            {
                cb2.Items.Clear();
                cb3.Items.Clear();
                cb4.Items.Clear();

                cb2.Items.Add("Off"); 
                cb2.Items.Add("Assistant_ID"); 
                cb2.Text = "Assistant_ID";

                cb3.Items.Add("Off");
                cb3.Items.Add("Client_ID");
                cb3.Text = "Client_ID";

                cb4.Items.Add("Off");
                cb4.Items.Add("Treatment_ID");
                cb4.Text = "Treatment_ID";

                cb4.Visible = true;
                cb5.Visible = true;
                cb6.Visible = true;
                cb7.Visible = true;
                btnT5.Visible = true;
                cbC.Checked = false;
                cbT.Checked = false;
                cbD.Checked = false;
            }
            else if (cb1.Text == "Assistant_ID")
            {
                cb2.Items.Clear();
                cb3.Items.Clear();
                cb4.Items.Clear();

                cb2.Items.Add("Off");
                cb2.Items.Add("First_Name");
                cb2.Text = "First_Name";
                cb3.Items.Add("Off");
                cb3.Items.Add("Last_Name");
                cb3.Text = "Last_Name";
                cb4.Items.Add("Off");
                cb4.Items.Add("Contact_Num");
                cb4.Text = "Contact_Num";

                cb4.Visible = true;
                cb5.Visible = false;
                cb6.Visible = false;
                cb7.Visible = false;
                btnT5.Visible = false;
                cbC.Checked = false;
                cbT.Checked = false;
                cbD.Checked = false;
            }
            else if (cb1.Text == "Client_ID")
            {
                cb2.Items.Clear();
                cb3.Items.Clear();
                cb4.Items.Clear();

                cb2.Items.Add("Off");
                cb2.Items.Add("First_Name");
                cb2.Text = "First_Name";
                cb3.Items.Add("Off");
                cb3.Items.Add("Last_Name");
                cb3.Text = "Last_Name";
                cb4.Items.Add("Off");
                cb4.Items.Add("Contact_Num");
                cb4.Text = "Contact_Num";

                cb4.Visible = true;
                cb5.Visible = false;
                cb6.Visible = false;
                cb7.Visible = false;
                btnT5.Visible = false;
                cbC.Checked = false;
                cbT.Checked = false;
                cbD.Checked = false;
            }
            else if (cb1.Text == "Treatment_ID")
            {
                cb2.Items.Clear();
                cb3.Items.Clear();

                cb2.Items.Add("Off");
                cb2.Items.Add("Treatment_Description");
                cb2.Text = "Treatment_Description";
                cb3.Items.Add("Off");
                cb3.Items.Add("Treatment_Price");
                cb3.Text = "Treatment_Price";

                cb4.Text = "Off";

                cb4.Visible = false;
                cb5.Visible = false;
                cb6.Visible = false;
                cb7.Visible = false;
                btnT5.Visible = false;
                cbC.Checked = false;
                cbT.Checked = false;
                cbD.Checked = false;
            }
            LoadDvg();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            LoadDvg();
        }
        string sql = "";
        public String GenSql()
        {

            if (cb1.Text == "Booking_ID")
            {
                sql = "SELECT Booking_ID ";
                if (cb2.Text != "Off")
                {
                    sql += ", " + cb2.Text + " ";
                }
                if (cb3.Text != "Off")
                {
                    sql += ", " + cb3.Text + " ";
                }
                if (cb4.Text != "Off")
                {
                    sql += ", " + cb4.Text + " ";
                }
                if (cb5.Text != "Off")
                {
                    sql += ", Booking_Time ";
                }
                if (cb6.Text != "Off")
                {
                    sql += ", Booking_IsPayed , Booking_IsAttended ";
                }
                if (cb7.Text != "Off")
                {
                    sql += ", Booking_Date ";
                }
                sql += "FROM Booking";
                if ((cbD.Checked == true || cbT.Checked == true||cbC.Checked == true))
                {
                    sql += " WHERE ";
                }
                if (cbD.Checked == true)
                {
                    if (cbC.Checked == true || cbT.Checked == true)
                        sql += " AND ";
                    sql += "Booking_Date BETWEEN '" +dtpD1.Text+ "' AND '" + dtpD2.Text + "'";
                }
                if (cbT.Checked == true)
                {
                    if (cbD.Checked == true || cbC.Checked == true)
                        sql += " AND ";
                    sql += "Booking_Time BETWEEN '" + dtpT1.Text + ":00' AND '" + dtpT2.Text + ":00'";
                }
                if (cbC.Checked == true)
                {
                    if (cbD.Checked == true|| cbT.Checked == true)
                        sql += " AND ";
                    if (cba.Visible == true && cbp.Visible == true)
                        sql += "Booking_isAttended = '" + cba.Checked + "' AND Booking_isPayed = '" + cbp.Checked + "'";
                    else if(cba.Visible == true)
                        sql += "Booking_isAttended = '" + cba.Checked + "' ";
                    else if(cbp.Visible == true)
                        sql += "Booking_isPayed = '" + cbp.Checked+"'";

                }

            }
            else if (cb1.Text == "Treatment_ID")
            {
                sql = "SELECT Treatment_ID ";
                if (cb2.Text != "Off")
                {
                    sql += ", " + cb2.Text + " ";
                }
                if (cb3.Text != "Off")
                {
                    sql += ", " + cb3.Text + " ";
                }
                sql += "FROM Treatment";
            }
            else if (cb1.Text == "Client_ID")
            {
                sql = "SELECT Client_ID ";
                if (cb2.Text != "Off")
                {
                    sql += ", " + cb2.Text + " ";
                }
                if (cb3.Text != "Off")
                {
                    sql += ", " + cb3.Text + " ";
                }
                if (cb4.Text != "Off")
                {
                    sql += ", " + cb4.Text + " ";
                }
                sql += "FROM Client";
            }
            else if (cb1.Text == "Assistant_ID")
            {
                sql = "SELECT Assistant_ID ";
                if (cb2.Text != "Off")
                {
                    sql += ", " + cb2.Text + " ";
                }
                if (cb3.Text != "Off")
                {
                    sql += ", " + cb3.Text + " ";
                }
                if (cb4.Text != "Off")
                {
                    sql += ", " + cb4.Text + " ";
                }
                sql += "FROM NailAss";
            }
            return sql;
        }

        public void LoadDvg()
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter adapter;

            ds.Tables.Clear();
            dvgR.DataSource = ds;
            dvgR.Refresh();
            string sql1;
            if (cb1.Text == "Booking_ID")
            {
                sql1 = GenSql();
                try
                {
                    adapter = new SqlDataAdapter(sql1, cnn);
                    ds.Clear();
                    cnn.Open();
                    adapter.Fill(ds);
                    dvgR.DataSource = ds.Tables[0];
                    cnn.Close();
                 }
                catch
                {

                }
            }
            else if (cb1.Text == "Treatment_ID")
            {
                sql1 = GenSql();
                try
                {
                    adapter = new SqlDataAdapter(sql1, cnn);
                    ds.Clear();
                    cnn.Open();
                    adapter.Fill(ds);
                    dvgR.DataSource = ds.Tables[0];
                    cnn.Close();
                }
                catch
                {

                }
            }
            else if (cb1.Text == "Client_ID")
            {
                sql1 = GenSql();
                try
                {
                    adapter = new SqlDataAdapter(sql1, cnn);
                    ds.Clear();
                    cnn.Open();
                    adapter.Fill(ds);
                    dvgR.DataSource = ds.Tables[0];
                    cnn.Close();
                }
                catch
                {

                }
            }
            else if (cb1.Text == "Assistant_ID")
            {
                sql = GenSql();
                try
                {
                    adapter = new SqlDataAdapter(sql, cnn);
                    ds.Clear();
                    cnn.Open();
                    adapter.Fill(ds);
                    dvgR.DataSource = ds.Tables[0];
                    cnn.Close();
                }
                catch
                {

                }
            }

        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDvg();
        }

        private void cb3_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadDvg();
        }

        private void cb4_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadDvg();
        }

        private void cba_CheckedChanged(object sender, EventArgs e)
        {
            LoadDvg();
        }

        private void dtpT_ValueChanged(object sender, EventArgs e)
        {
            LoadDvg();
        }

        private void lblF_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dvgR.SelectedCells[0].Value.ToString());
            LoadDvg();
        }

        private void dtpD1_ValueChanged(object sender, EventArgs e)
        {
            LoadDvg();
        }

        private void cbp_CheckedChanged(object sender, EventArgs e)
        {

            LoadDvg();
        }

        private void cbC_CheckedChanged(object sender, EventArgs e)
        {

            LoadDvg();
        }

        private void cbT_CheckedChanged(object sender, EventArgs e)
        {

            LoadDvg();
        }

        private void cbD_CheckedChanged(object sender, EventArgs e)
        {

            LoadDvg();
        }

        private void dtpT1_ValueChanged(object sender, EventArgs e)
        {
            LoadDvg();

        }

        private void dtpD2_ValueChanged(object sender, EventArgs e)
        {

            LoadDvg();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            cb1.Text = "Treatment_ID";
            cb2.Text = "Off";
            cb3.Text = "Off";
            LoadDvg();
            int iBucks = dvgR.Rows.Count - 1;
            String[] buckets = new String[iBucks];
            int[] Drops = new int[iBucks];
            for (int i = 0; i < iBucks; i++)
            {
                buckets[i] = (dvgR.Rows[i].Cells[0].Value.ToString());
            }



            cb1.Text = "Booking_ID";
            cb2.Text = "Off";
            cb3.Text = "Off";
            cb4.Text = "Treatment_ID";
            cb5.Text = "Off";
            cb6.Text = "Off";
            cb7.Text = "Off";
            LoadDvg();
          for (int i = 0; i < dvgR.Rows.Count-1; i++)
          {
                for (int i2 = 0; i2 < iBucks; i2++)
                    if (dvgR.Rows[i].Cells[1].Value.ToString() == buckets[i2])
                      Drops[i2] += 1;
          }

            for (int i = 0; i < iBucks - 1; i++)
                for (int j = 0; j < iBucks - i - 1; j++)
                    if (Drops[j] < Drops[j + 1])
                    {
                        int itemp = Drops[j];
                        Drops[j] = Drops[j + 1];
                        Drops[j + 1] = itemp;

                        String stemp = buckets[j];
                        buckets[j] = buckets[j + 1];
                        buckets[j + 1] = stemp;

                    }

                        tbOut.Text = "Top 5 Treatments: \r\n";
          if (iBucks <= 5)
                for (int i2 = 0; i2 < iBucks; i2++)
                    tbOut.Text+= "Treatment Id:" +buckets[i2]+ " Performed at: "+ Drops[i2]+ " Bookings\r\n";
          else
                for (int i2 = 0; i2 < 5; i2++)
                    tbOut.Text += "Treatment Id:"+buckets[i2] + " Performed at: " + Drops[i2]+ " Bookings\r\n";
          LoadDvg();
        }

        private void btnCI_Click(object sender, EventArgs e)
        {


            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter adapter;
            
            ds.Tables.Clear();
            dvgR.DataSource = ds;
            dvgR.Refresh();

            if (cb1.Text == "Booking_ID")
            {
                sql = "SELECT Booking.Booking_ID, Treatment.Treatment_Price ,Booking.Booking_Date FROM Booking INNER JOIN Treatment ON Booking.Treatment_ID = Treatment.Treatment_ID ";
                try
                {
                    if (cbD.Checked == true)
                    {
                        sql += "WHERE Booking_Date BETWEEN '" + dtpD1.Text + "' AND '" + dtpD2.Text + "'";
                    }

                    adapter = new SqlDataAdapter(sql, cnn);
                    ds.Clear();
                    cnn.Open();
                    adapter.Fill(ds);
                    dvgR.DataSource = ds.Tables[0];
                    cnn.Close();
                    double total = 0;
                    for (int i = 0; i < dvgR.Rows.Count - 1; i++)
                    {
                        total += double.Parse(dvgR.Rows[i].Cells[1].Value.ToString());
                    }
                    if (cbD.Checked == true)
                    {
                        tbOut.Text = "a total of R" + total.ToString() + " was made between "+ dtpD1.Text + " and " + dtpD2.Text + "";;
                    }
                    else
                        tbOut.Text ="a total of R" +total.ToString()+" was made ";
                }
                catch
                {

                }
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {

        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            tbOut.Text = "";
            int cells = 0;
            if (cb1.Text != "Off")
            {
                tbOut.Text += cb1.Text + "   \t";
            }
            if (cb2.Text != "Off")
            {
                cells += 1;
                tbOut.Text += cb2.Text + "\t";
            }
            if (cb3.Text != "Off")
            {
                cells += 1;
                tbOut.Text += cb3.Text + "\t";
            }
            if (cb4.Text != "Off")
            {
                cells += 1;
                tbOut.Text += cb4.Text + "\t";
            }
            if (cb5.Text != "Off")
            {
                cells += 1;
                tbOut.Text += cb5.Text + "\t \t";
            }
            if (cb6.Text != "Off")
            {
                cells += 2;
                tbOut.Text += "Payed \t \tAttended \t \t";
            }
            if (cb7.Text != "Off")
            {
                cells += 1;
                tbOut.Text += cb7.Text + "\t";
            }
            tbOut.Text += "\r\n---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\r\n";
            for (int i = 0; i < dvgR.Rows.Count - 1; i++)
            {
                for (int i2 = 0; i2 <= cells; i2++)
                    tbOut.Text += dvgR.Rows[i].Cells[i2].Value.ToString()+"\t\t";

                tbOut.Text += "\r\n";
            }

            tbOut.Text += "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\r\n";
        }
    }
}
