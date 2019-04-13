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
    public partial class ReadForm : Form
    {
        public ReadForm()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e) //Done by Low Chong Han(114643Q)
        {
            StreamReader sr = new StreamReader("CustomerRecord.txt");
            string customerrecord;

            customerrecord = sr.ReadLine();
            while (customerrecord != null)
            {

                rtbReadDisplay.AppendText(customerrecord + Environment.NewLine);

                customerrecord = sr.ReadLine();
            }
            sr.Close();
        }

        private void rtbReadDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            
          this.Close();
            
            
        }

    }
}