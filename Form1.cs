using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljanjeIznimkama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gumb_Click(object sender, EventArgs e)
        {
            try 
            {
                int godRod = Convert.ToInt16(txtUnos.Text);
                txtIspis.Text = godRod.ToString();
            }  
            catch (Exception greska)
            {
                DialogResult odabir = MessageBox.Show("Molim vas da upisete broj \n Da li želite izbrisati vaš postojeći unos? ", "Pogrešan unos ", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                switch(odabir)
                {
                    case DialogResult.Yes:
                        txtUnos.Clear();
                        break;
                    case DialogResult.No:
                        break;
                }
                txtUnos.Select();
            }

        }
    }
}
