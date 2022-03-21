using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratikumWeek5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rBtnMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxAktif.Checked == true)
            {
                if (rBtnMerah.Checked == true)
                {
                    lblOutput.ForeColor = Color.Red;
                }
                else
                {
                    lblOutput.ForeColor = Color.Blue;
                }
            }
        }

        private void rBtnBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxAktif.Checked == true)
            {
                if (rBtnMerah.Checked == true)
                {
                    lblOutput.ForeColor = Color.Red;
                }
                else
                {
                    lblOutput.ForeColor = Color.Blue;
                }
            }
        }

        private void cBoxAktif_CheckedChanged(object sender, EventArgs e)
        {

            if (cBoxAktif.Checked == true)
            {
                if (rBtnMerah.Checked == true)
                {
                    lblOutput.ForeColor = Color.Red;
                }
                else
                {
                    lblOutput.ForeColor = Color.Blue;
                }
            }
            else
            {
                lblOutput.ForeColor = Color.Black;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lBoxKoleksi.Items.Contains(txtBoxData.Text))
            {
                MessageBox.Show("input kembar");
            }
            else
            {
                lBoxKoleksi.Items.Add(txtBoxData.Text);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lBoxKoleksi.Items.Clear();
            lblOutput.ForeColor = Color.Black;
            lblOutput.Text = "";
            txtBoxData.Text = "";
            rBtnMerah.Checked = true;
            cBoxAktif.Checked = false;
            

        }

        private void lBoxKoleksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
           

            lblOutput.Text = lBoxKoleksi.SelectedItem.ToString();
        }
    }
}
