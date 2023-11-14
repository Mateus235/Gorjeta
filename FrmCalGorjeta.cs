using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        private void calcularGorjeta(int porcentagem)
        {

                double num1, num2, res;


                num1 = Convert.ToDouble(txtValorDaConta.Text);
                num2 = porcentagem / 100 * num1;


                res = num1 + num2;


            txtValorDaGorjeta.Text = num2.ToString();
            txtTotal.Text = res.ToString();
            
            
            

            
     


        }
        private void btnCalcularGorjeta_Click(object sender, EventArgs e)
        {
            
            switch (comboBox1.Text)
            {
                case "excelente-10%":
                    calcularGorjeta(10);
                    break;

                case "ótimo-8%":
                    calcularGorjeta(8);
                    break;
                    

                case "bom-5%":
                    calcularGorjeta(5);
                    break;

                case "ruim-2%":
                    calcularGorjeta(2);
                    break;

                default:
                    break ;
            }

        }

        private void ltbUsado_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "select * from tbFuncionarios where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("nome",MySqlDbType.VarChar,100).Value = "@nome;";

            comm.Connection = Conectar.obterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
           

            Conectar.fecharConexao();









        


        }
    }





     
    }
            
            
          
        
 
        
    

