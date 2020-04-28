using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pa6
{
    public partial class frmCWID : Form
    {
        public frmCWID()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txtOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain myform = new frmMain(txtCWID.Text);
            if(myform.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                this.Close();

            }
        }
    }
}
