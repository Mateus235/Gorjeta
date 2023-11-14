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
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        public int cadastro()
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbFuncionarios(codFunc,nome,email,cpf,dNasc,dataGor)values(@codFunc,@nome,@email,@cpf,@dNasc,@dataGor);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Add("@codFunc", MySqlDbType.VarChar, 1).Value = txtCodigo.Text;
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 30).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCPF.Text;
            comm.Parameters.Add("@dNasc", MySqlDbType.Date).Value = Convert.ToDateTime(dtpDNasc.Text);
            comm.Parameters.Add("@dataGor", MySqlDbType.Date).Value = Convert.ToDateTime(dateTimePicker1.Text);


            comm.Connection = Conectar.obterConexao();

            int res = comm.ExecuteNonQuery();

            Conectar.fecharConexao();

            return res;


        }

        public void carregarFuncionario(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionarios where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conectar.obterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();

            DR.Read();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cadastro() == 1)
            {
                MessageBox.Show("cadastrado com sucesso!!!");
            }
            else
            {
                MessageBox.Show("erro no cadastro");
            }

        }
        private void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mskCPF.Enabled = true;
            dtpDNasc.Enabled = true;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = false;

            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            mskCPF.Clear();
        }
        private void ExcluirFuncionario(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbFuncionarios where codFunc = @codFunc;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("codFunc", MySqlDbType.Int32).Value = codigo;

            comm.Connection = Conectar.obterConexao();

            comm.ExecuteNonQuery();


            Conectar.fecharConexao();


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("certeza que deseja excluir?");

            if (resp == DialogResult.OK)
            {
                ExcluirFuncionario(Convert.ToInt32(txtCodigo));

            }
            else
            {

            }

        }
        public int AlterarFuncionario(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = " update tbFuncionarios set nome = @nome,email =@email,cpf=@cpf, where codFunc=@codFunc;";
            comm.CommandType = CommandType.Text;


            comm.Parameters.Add("@codFunc", MySqlDbType.VarChar, 1).Value = txtCodigo.Text;
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 30).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCPF.Text;
            comm.Parameters.Add("@dNasc", MySqlDbType.Date).Value = Convert.ToDateTime(dtpDNasc.Text);
            comm.Parameters.Add("@dataGor", MySqlDbType.Date).Value = Convert.ToDateTime(dateTimePicker1.Text);

            comm.Connection = Conectar.obterConexao();

            int res = comm.ExecuteNonQuery();

            Conectar.fecharConexao();

            return res;
            

        }


    }


    }

