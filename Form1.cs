using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        int nr, countX, countO = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset reset = new reset();
            reset.ShowDialog();
            if(reset.vdd == true)
            {
                b1.Text = ""; b2.Text = ""; b3.Text = ""; b4.Text = ""; b5.Text = ""; b6.Text = ""; b7.Text = ""; b8.Text = ""; b9.Text = "";
                b1.Enabled = true; b2.Enabled = true; b3.Enabled = true; b4.Enabled = true; b5.Enabled = true; b6.Enabled = true; b7.Enabled = true; b8.Enabled = true; b9.Enabled = true;
                
            }
            if(reset.vdd == false)
            {
                txtPontosO.Text = "0";
                txtPontosX.Text = "0";
                countO = 0;
                countX = 0;

            }  
            
           
        }

        public void btn_click(object sender, EventArgs e)
        {
            nr++;
            Button b = (Button)sender;
            if(nr%2!= 0)
            {
                b.Text = "X";
                
            }
            else
            {
                b.Text = "O";
            }
            b.Enabled = false;
            if(b.Text == "X"){txtAtualPlayer.Text = "O";} else { txtAtualPlayer.Text = "X";}

            if ((b1.Text == b2.Text && b2.Text == b3.Text && b1.Enabled==false)
                 || (b4.Text == b5.Text && b5.Text == b6.Text && b4.Enabled == false)  ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b7.Enabled == false) ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b1.Enabled == false) ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b2.Enabled == false) ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b3.Enabled == false) ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b1.Enabled == false) ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b3.Enabled == false))
            {
                if (nr %2!= 0)
                {
                    //MessageBox.Show("X WINS");
                    countX += 1;
                }
                else
                {
                    //MessageBox.Show("O WINS");
                    countO += 1;
                }
                
                
                string message = "Escolha sim para jogar novamente?";
                string title = "JOGAR NOVAMENTE?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    b1.Text = ""; b2.Text = ""; b3.Text = ""; b4.Text = ""; b5.Text = ""; b6.Text = ""; b7.Text = ""; b8.Text = ""; b9.Text = "";
                    b1.Enabled = true; b2.Enabled = true; b3.Enabled = true; b4.Enabled = true; b5.Enabled = true; b6.Enabled = true; b7.Enabled = true; b8.Enabled = true; b9.Enabled = true;
                    txtPontosX.Text = countX.ToString();
                    txtPontosO.Text = countO.ToString();
                }
                else
                {
                    this.Close();
                }

                

                
               

            }

        }

    }
}
