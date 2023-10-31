using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorjeta
{
    public partial class FrmCalGorjeta : Form
    {
        public FrmCalGorjeta()
        {
            InitializeComponent();
            comboBox1.Items.Add("excelente-10%");
            comboBox1.Items.Add("otimo-8%");
            comboBox1.Items.Add("bom-5%");
            comboBox1.Items.Add("ruim-2%");
        }

        private double QualidadeDoServiço(string qualidadeDoServico)
        {
            switch (qualidadeDoServico)
            {
                case "excelente-10%":
                    return 10;
                case "ótimo-8%":
                    return 8;
                case "bom-5%":
                    return 5;
                case "ruim-2%":
                    return 2;
                default:
                    return 0;
            }
        }



        
        private void btnCalcularGorjeta_Click_1(object sender, EventArgs e)
        {
            try
            {





                double num1, num2, res;

                num1 = Convert.ToInt32(txtValorDaConta.Text);
                num2 = Convert.ToInt32(txtValorDaGorjeta.Text);
               

                res = num1 * num2 / 100;
                txtTotal.Text = res.ToString();






            }
            catch (Exception )
            {
                MessageBox.Show("erro");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
            
            
          
        }
 
        
    

