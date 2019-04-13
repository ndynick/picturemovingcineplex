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
    {   //Start of code
        int quantity = 0;
        float price = 0f;
        float total = 0f;
        float totalprice = 0f;
        float grandtotal = 0f;
        string time;
        string movie;
        string weekResult;
        string card;
        string payment;
        string displayrecord;
     //############################################################################################################################################################################
        public PmCineplexForm()
        {
            InitializeComponent();
            MessageBox.Show(".:: Welcome to PM Moving Ticketing System ::.", "W-E-L-C-O-M-E"); //Done by Nick Low
        }
     //############################################################################################################################################################################
        //Start of btnconfirm
        private void btnconfirm_Click(object sender, EventArgs e)
        {
            try //try-catch Done by Nick Low
            {
                if (int.TryParse(txttickets.Text, out quantity) == false) //Done by Nick Low and Hong Zhi
                {
                    MessageBox.Show("Please enter a value in numeric", "Invalid value!");

                    txttickets.Clear();
                    txttickets.Focus();
                }
                else if (quantity < 1 || quantity > 30)
                {
                    MessageBox.Show("Please enter a number within 1 to 30", "Incorrect number range!");

                    txttickets.Clear();
                    txttickets.Focus();
                }

     //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                else
                {
                    //Done by Nick Low
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
                        MessageBox.Show("Please select a movie title!", "Error");
                        rdothor.Focus();
                    }
    //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    //Done by Nick Low
                    bool selected = false;
                    selected = (rdo1pm.Checked || rdo4pm.Checked || rdo7pm.Checked || rdo930pm.Checked);
                    if (selected == true)
                    {
                        if (rdo1pm.Checked == true)
                            Slot1pm();
                        else if (rdo4pm.Checked == true)
                            Slot4pm();
                        else if (rdo7pm.Checked == true)
                            Slot7pm();
                        else if (rdo930pm.Checked == true)
                            Slot930pm();
                        total = price * quantity;
                    }
                    else
                    {
                        MessageBox.Show("Please select a time slot!", "Error");
                        rdo1pm.Focus();
                    }
   //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    //Done by Hong Zhi
                    bool week = false;
                    week = (rdoday.Checked || rdoend.Checked);
                    if (week == true)
                    {
                        if (rdoday.Checked == true)
                            Weekday();
                        else if (rdoend.Checked == true)
                            Weekend();
                    }
                    else
                    {
                        MessageBox.Show("Please select either Weekday or Weekend!", "Error");
                        rdoday.Focus();
                    }
  //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    //Done by Hong Zhi
                    bool card = false;
                    card = (rdoyes.Checked || rdono.Checked);
                    if (card == true)
                    {
                        if (rdoyes.Checked == true)
                            yes();
                        else if (rdono.Checked == true)
                            No();


                    }
                    else
                    {
                        MessageBox.Show("Please select whether you have a passion card!", "Error");
                        rdono.Focus();
                    }
   //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
                    //Done by Hong Zhi
                    bool selection = false;
                    selection = (rdocash.Checked || rdocredit.Checked);
                    if (selection == true)
                    {
                        if (rdocash.Checked == true)
                            payment = "Cash";
                        else if (rdocredit.Checked == true)
                            payment = "Credit";
                    }
                    else
                    {
                        MessageBox.Show("Please select your payment option!", "Error");
                        rdocash.Focus();
                    }
                    lbltotalprice.Text = totalprice.ToString("C");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
                MessageBox.Show("Please fill in all the blank!", "Error");
            }
            finally
            {
            }
        }
      //End of btnconfirm
     //############################################################################################################################################################################
        private void btnclear_Click(object sender, EventArgs e) //Done by Hong Zhi
        {
            txttickets.Clear();
            lbltotalprice.Text = "" ;
            ClearMovies();
            ClearTimeSlots();
            ClearWeekDayEnd();
            ClearCard();
            ClearPayment();
        }
     //###########################################################################################################################################################################
        private void btnrevenue_Click(object sender, EventArgs e) //Done by Hong Zhi, Modified by Nick Low
        {
            try //try-catch Done by Nick Low
            {
                grandtotal = grandtotal + totalprice;

                displayrecord = movie.PadRight(24) + txttickets.Text.PadRight(31) + time.PadRight(29);
                displayrecord = displayrecord + weekResult.PadRight(39) + card.PadRight(24) + payment.PadRight(18);
                displayrecord = displayrecord + totalprice.ToString("C").PadRight(12);
                displayrecord = displayrecord + grandtotal.ToString("C").PadRight(17);
                displayrecord = displayrecord + dateTimePicker1.Text; //Current Date
                displayrecord = displayrecord + "  " + dateTimePicker2.Text.PadRight(10); //Current Time
                rtbdisplay.AppendText((displayrecord) + Environment.NewLine);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select the Confirm button to calculate the payment!", "Error");
                MessageBox.Show("Then select the Revenue button to display record!", "Error");
            }
            finally
            {
            }
        }
    //###########################################################################################################################################################################
        private void btnsaveNexit_Click(object sender, EventArgs e) //Done by Nick Low
        {
            StreamWriter_wr();
            MessageBox_Updated();
            MessageBox_Closing(); 
        }
   //###########################################################################################################################################################################
        private void btnExit_Click(object sender, EventArgs e) //Done by Nick Low
        {
            this.Close();
        }
   //###########################################################################################################################################################################
        private void logoBox_Click(object sender, EventArgs e)
        {
            //As for our movie cineplex's logo, both Nick Low & Hong Zhi designed it together.
        }
   //###########################################################################################################################################################################
        private void btnRead_Click(object sender, EventArgs e) //Done by Nick Low
        {
            ReadForm RF = new ReadForm();
            RF.ShowDialog();
        }
   //###########################################################################################################################################################################
        private void Slot1pm() //Done by Hong Zhi
        {
            price = 7.50f;
            time = "1pm";
        }
        private void Slot4pm() //Done by Hong Zhi
        {
            price = 7.50f;
            time = "4pm";
        }
        private void Slot7pm() //Done by Hong Zhi
        {
            price = 9.00f;
            time = "7pm";
        }
        private void Slot930pm() //Done by Hong Zhi
        {
            price = 9.00f;
            time = "9.30pm";
        }
    //###########################################################################################################################################################################
        private void Weekday()  //Done by Hong Zhi
        {
            totalprice = totalprice;
            weekResult = "Weekday";
        }
        private void Weekend()  //Done by Hong Zhi
        {
            totalprice = (totalprice * 1.10f);
            weekResult = "Weekend";
        }
    //###########################################################################################################################################################################
        private void yes() //Done by Hong Zhi
        {
            totalprice = total * 0.9f;
            card = "Yes";
        }
        private void No() //Done by Hong Zhi
        {
            totalprice = total;
            card = "No";
        }
    //###########################################################################################################################################################################
        private void ClearMovies() //Done by Nick Low
        {
            rdothor.Checked   = false;
            rdopriest.Checked = false;
            rdoarthur.Checked = false;
        }
    //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void ClearTimeSlots() //Done by Nick Low
        {
            rdo1pm.Checked    = false;
            rdo4pm.Checked    = false;
            rdo7pm.Checked    = false;
            rdo930pm.Checked  = false;
        }
    //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void ClearWeekDayEnd() //Done by Nick Low
        {
            rdoday.Checked    = false;
            rdoend.Checked    = false;
        }
   //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void ClearCard() //Done by Nick Low
        {
            rdoyes.Checked    = false;
            rdono.Checked     = false;
        }
   //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void ClearPayment() //Done by Nick Low
        {
            rdocash.Checked   = false;
            rdocredit.Checked = false;
        }
   //###########################################################################################################################################################################
        private void StreamWriter_wr() //Done by Nick Low
        {
            StreamWriter wr = new StreamWriter("CustomerRecord.txt", false);
            wr.WriteLine(rtbdisplay.Text);
            wr.Close();
        }
    //###########################################################################################################################################################################
        private void MessageBox_Updated() //Done by Nick Low
        {
         MessageBox.Show("Record for " + "CustomerRecord.txt" + " is updated!", "Record is updated");
        }
    //###########################################################################################################################################################################
        private void MessageBox_Closing() //Done by Nick Low
        {
            DialogResult result = MessageBox.Show("Do you want to read your CustomerRecord.txt file?", "Yes or No", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Please select the To Read File's button on the top left hand corner!", "Please select...");
            }
            else
            {
                MessageBox.Show("Pm Cineplex application program is now close !", "Closing");
                MessageBox.Show("Have a nice day!", "Thanks for using!");
                this.Close();
            }
        }
   //###########################################################################################################################################################################
    }
}
//End of code

        

        






