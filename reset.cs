using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame 
{
    public partial class reset : Form 
    {
        public bool vdd;
        public reset()
        {
            InitializeComponent();
        }
        

        public void button1_Click(object sender, EventArgs e)
        {
            vdd = true;
            this.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            vdd = false;
            this.Close();
        }
    }
    
}
