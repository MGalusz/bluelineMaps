using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bluelineMaps
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string street = strretTextBox.Text;
            string city = cityTextBox.Text;
            string state = stateTextBox.Text;
            string zipCode = zipCodeTextBox.Text;

            try
            {
                StringBuilder queryDate = new StringBuilder();

                queryDate.Append("http://maps.google.com/maps?q=");

                if (street != string.Empty)
                {
                    queryDate.Append(street + "," + "+");
                }
                            if (city != string.Empty)
                {
                    queryDate.Append(city +","+ "+");
                }
                            if (state != string.Empty)
                            {
                                queryDate.Append(state + "," + "+");
                            }
                            if (zipCode != string.Empty)
                            {
                                queryDate.Append(zipCode + "," + "+");
                            }

                            webBrowser1.Navigate(queryDate.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
    }
}
