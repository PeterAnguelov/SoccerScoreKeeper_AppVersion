using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerScoreKeeper_AppVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int num = 0;
        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            num++;
            lblHelloWorld.Text = num.ToString();
        }

        private void btnRemovePoint_Click(object sender, EventArgs e)
        {
            if (num <= 0)
            {
                num = 0;
            } else
            {
                num--;
                lblHelloWorld.Text = num.ToString();
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            num = 0;
            lblHelloWorld.Text = num.ToString();
        }
    }
}
