using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GUI_movie
{
    public partial class PmCineplexForm : Form
    {    
        
        int quantity= 0;
        float total = 0f;
        float grandtotal = 0f;
        float totalprice = 0f;
        string movie;
        string time;
        string displayrecord;
        
        
         public PmCineplexForm()
        {
            InitializeComponent();
        }

        private void PmCineplexForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdocredit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            float price = 0f;
            string payment;
            

          {
             quantity = int.Parse(txttickets.Text);


             

                //Done by Low Chong Han(114643Q)
                bool selected = false;
                selected = (rdo1pm.Checked || rdo4pm.Checked || rdo7pm.Checked || rdo930pm.Checked);
                if (selected == true)
                {
                    if (rdo1pm.Checked == true)
                        price = 7.50f;
                    time = "1pm";
                    if (rdo4pm.Checked == true)
                        price = 7.50f;
                    time = "4pm";
                    if (rdo7pm.Checked == true)
                        price = 9.00f;
                    time = "7pm";
                    if (rdo930pm.Checked == true)
                        price = 9.00f;
                    time = "9.30pm";

                    total = price * quantity;
                }
                else
                {
                    MessageBox.Show("Please select a time slot!");
                    rdo1pm.Focus();
                }
                //Done by Low Chong Han(114643Q)
                bool choice = false;
                choice = (rdothor.Checked || rdopriest.Checked || rdoarthur.Checked);
                if (choice == true)
                {
                    if (rdothor.Checked == true)
                        movie = "Thor";
                    else if (rdopriest.Checked == true)
                        movie = "Priest";
                    else if (rdoarthur.Checked == true)
                        movie = "Arthur";
                }
                else
                {
                    MessageBox.Show("Please select a movie!");
                    rdothor.Focus();
                }

                //Done by Soh Hong Zhi(111253M)
                bool selection = false;
                selection = (rdocash.Checked || rdocredit.Checked);
                if (selection == true)
                {
                    if (rdocash.Checked == true)
                        payment = "Cash";
                    else if (rdocredit.Checked == true)
                        payment = "Visa";
                }
                else
                {
                    MessageBox.Show("Please select your payment option");
                    rdocash.Focus();
                }

                //Done by Soh Hong Zhi(111253M)
                bool card = false;
                card = (rdoyes.Checked || rdono.Checked);
                if (card == true)
                {
                    if (rdoyes.Checked == true)
                        totalprice = total * 0.9f;
                    else if (rdono.Checked == true)
                        totalprice = total;


                }
                else
                {
                    MessageBox.Show("Please select whether you have a passion card!");
                    rdono.Focus();
                }

                //Done by Soh Hong Zhi(111253M)
                bool week = false;
                week = (rdoday.Checked || rdoend.Checked);
                if (week == true)
                {
                    if (rdoday.Checked == true)
                    totalprice = totalprice;

                    if (rdoend.Checked == true)
                        totalprice = (totalprice * 1.10f); 
                }
                else
                {
                    MessageBox.Show("Please select either Weekday or Weekend!");
                    rdoday.Focus();
                }

                lbltotalprice.Text = totalprice.ToString("C");  //Done by Soh Hong Zhi(111253M)


            }
        }


                
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdo4pm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txttickets_TextChanged(object sender, EventArgs e)
        {   

          
                if (txttickets.TextLength > 0) //Done by Soh Hong Zhi(111253M)
                {

                    if (int.TryParse(txttickets.Text, out quantity) == false)
                    {
                        MessageBox.Show("Please enter a value in numeric");

                        txttickets.Clear();
                        txttickets.Focus();
                    }
                    else if (quantity < 1 || quantity > 30) //Done by Soh Hong Zhi(111253M) 
                    {
                        MessageBox.Show("Please enter a number from 0 to 30");

                        txttickets.Clear();
                        txttickets.Focus();
                    }

                }  

               else if (txttickets.Text == "")
            {
                MessageBox.Show("Please enter a value");

            }
           
                     
        }

        private void btnclear_Click(object sender, EventArgs e) //Done by Soh Hong Zhi(111253M)
        {
            txttickets.Clear();
            lbltotalprice.Text = ""; 
            
        }

        private void btnrevenue_Click(object sender, EventArgs e) //Done by Soh Hong Zhi(111253M) , Modified by Low Chong Han
        {

            
            grandtotal = grandtotal + totalprice;

            displayrecord =  movie.PadRight(10) + time.PadRight(13); 
            displayrecord = displayrecord + totalprice.ToString("C").PadRight(12);
            displayrecord = displayrecord + grandtotal.ToString("C").PadRight(14);
            displayrecord = displayrecord + dateTimePicker1.Text;
            displayrecord = displayrecord + "  " + dateTimePicker2.Text.PadRight(10);
            rtbdisplay.AppendText((displayrecord) + Environment.NewLine);     
        }

        private void btnexit_Click(object sender, EventArgs e) //Done by Low Chong Han(114643Q)
        {
            StreamWriter wr = new StreamWriter("CustomerRecord.txt", false);
            wr.WriteLine(rtbdisplay.Text);
            wr.Close();
            MessageBox.Show("Record for " + "CustomerRecord.txt" + " is updated!");
            MessageBox.Show("Pm Cineplex application program will now close !");
            this.Close();
        }

       

    
        
        private void rdocash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdothor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdopriest_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoarthur_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoyes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdono_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo1pm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo7pm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo930pm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
        
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void logoBox_Click(object sender, EventArgs e)
        {
            //As for our movie cineplex's logo, both Low Chong Han(114643Q) and Soh Hong Zhi(111253M) designed it together.
        }

       

        private void lbltotalprice_Click(object sender, EventArgs e)
        {

        }



 

        private void btnRead_Click(object sender, EventArgs e) //Done by Low Chong Han(114643Q)
        {
            ReadForm RF = new ReadForm();
            RF.ShowDialog();
        }

        

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        
{
  
}



        }

            
    }



