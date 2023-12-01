using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD2ASamylly.BLL;
using CRUD2ASamylly.Model;

namespace CRUD2ASamylly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //metodo para salvar
        private void Salvar(Pessoa pessoa)
        {
            PessoaBLL pessoaBLL= new PessoaBLL();
            try
            {

            }
            catch(Exception) 
            {
                throw;
            }
        }

        //metodo para listar os dados no grid
        private void Listar()
        {
            PessoaBLL pessoaBLL = new PessoaBLL();
            try
            {
             dataGridView.DataSource = pessoaBLL.Listar();

                //renomear colunas
                dataGridView.Columns[0].HeaderText = "Código";
                dataGridView.Columns[1].HeaderText = "Nome";
                dataGridView.Columns[2].HeaderText = "Dt Nasc";
                dataGridView.Columns[3].HeaderText = "Sexo";
                dataGridView.Columns[4].HeaderText = "CPF";
                dataGridView.Columns[5].HeaderText = "Tel. Celular";
                dataGridView.Columns[6].HeaderText = "Endereço";
                dataGridView.Columns[7].HeaderText = "Bairro";
                dataGridView.Columns[8].HeaderText = "Cidade";
                dataGridView.Columns[9].HeaderText = "UF";
                dataGridView.Columns[10].HeaderText = "CEP";

                //Remover colunas do datagrid
                dataGridView.Columns[6].Visible = false;
                dataGridView.Columns[7].Visible = false;
                dataGridView.Columns[8].Visible = false;
                dataGridView.Columns[9].Visible = false;
                dataGridView.Columns[10].Visible = false;

                //largura das colunas
                dataGridView.Columns[0].Width = 45;
                dataGridView.Columns[1].Width = 160;
                dataGridView.Columns[2].Width = 70;
                dataGridView.Columns[3].Width = 40;
                dataGridView.Columns[4].Width = 75;
                dataGridView.Columns[5].Width = 85;

            }
            catch (Exception erro) 
            {
                MessageBox.Show("Erro ao exibir os dados!\n"+erro, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void btnExibir_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            Salvar(pessoa);
        }
    }
}
