using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static List<Pessoa> Pessoas;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            txtNomePesquisado.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos");
            }
            else if (rdbCelular.Checked == true && (txtTelefone.Text.Substring(5, 1) != "9" || (txtTelefone.Text.Substring(6, 1) != "8" && txtTelefone.Text.Substring(6, 1) != "9")))
            {
                MessageBox.Show("Telefone inválido!");
            }
            else
            {
                bool valido = true;
                Pessoa pessoa = new Pessoa(); //CRIA UM NOVO OBJETO DO TIPO PESSOA

                pessoa.Nome = txtNome.Text; //ARMAZENA O NOME DA PESSOA
                pessoa.Telefone = txtTelefone.Text; //ARMAZENA O TELEFONE DA PESSOA

                if (Pessoas == null)
                {
                    Pessoas = new List<Pessoa>(); //NA PRIMEIRA VEZ, INSTANCIA UMA NOVA LISTA DE PESSOAS
                }

                foreach (Pessoa p in Pessoas)
                {
                    if (p.Telefone == txtTelefone.Text)
                    {
                        valido = false;
                        MessageBox.Show("Telefone já adicionado!");
                    }

                }

                if (pessoa.Nome == null)
                {
                    MessageBox.Show("Digite um nume!");
                }

                Pessoas.Add(pessoa); //ARMAZENA O CONTATO NA LISTA

                lblContador.Text = Pessoas.Count().ToString(); //ATUALIZA O NUMERO DE REGISTROS
                dgvContatos.DataSource = null; //LIMPA A LISTA DA TABELA
                dgvContatos.DataSource = Pessoas; //ESCREVE A LISTA DE CONTATOS NA TABELA

                txtNome.Text = string.Empty; //LIMPA O CAMPO
                txtTelefone.Text = string.Empty; //LIMPA O CAMPO
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvContatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um registro.");
            }
            else
            {
                for (int i = 0; i < dgvContatos.SelectedRows.Count; i++)
                {
                    string Nome = dgvContatos.SelectedRows[i].Cells[0].Value.ToString();
                    string Telefone = dgvContatos.SelectedRows[i].Cells[1].Value.ToString();

                    Pessoa pessoa = Pessoas.Find(p => p.Telefone == Telefone && p.Nome == Nome);

                    Pessoas.Remove(pessoa);
                }

                lblContador.Text = Pessoas.Count().ToString(); //ATUALIZA O NUMERO DE REGISTROS
                dgvContatos.DataSource = null; //LIMPA A LISTA DA TABELA
                dgvContatos.DataSource = Pessoas; //ESCREVE A LISTA DE CONTATOS NA TABELA
            }
        }

        private void rdbCelular_CheckedChanged(object sender, EventArgs e)
        {
            txtTelefone.Text = string.Empty;
            txtTelefone.Mask = "(00) 00000-0000";
        }

        private void rdbRes_CheckedChanged(object sender, EventArgs e)
        {
            txtTelefone.Text = string.Empty;
            txtTelefone.Mask = "(00) 0000-0000";
        }

        private void txtNomePesquisado_TextChanged(object sender, EventArgs e)
        {
            if (Pessoas != null)
            {
                //List<Pessoa> listaFiltrada = Pessoas.FindAll(p => p.Nome.Contains(txtNomePesquisado.Text)).ToList();
                //dgvContatos.DataSource = null; //LIMPA A LISTA DA TABELA
                //dgvContatos.DataSource = listaFiltrada; //ESCREVE A LISTA DE CONTATOS NA TABELA

                List<Pessoa> listaFiltrada = new List<Pessoa>();

                foreach (Pessoa item in Pessoas)
                {
                    if (item.Nome.Contains(txtNomePesquisado.Text.Trim()))
                    {
                        listaFiltrada.Add(item);
                    }
                }

                dgvContatos.DataSource = null; //LIMPA A LISTA DA TABELA
                dgvContatos.DataSource = listaFiltrada; //ESCREVE A LISTA DE CONTATOS NA TABELA
            }
        }
    }
}
