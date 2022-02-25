using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIP_Lounge_Club
{
    public partial class Vip : Form
    {
        public Vip()
        {
            InitializeComponent();
        }



        private void txtLocaliza_Click(object sender, EventArgs e)
        {
            int Cpf = Convert.ToInt32(txtCpf.Text.Trim());
            Vip vip = new Vip();
            vip.Localiza(Cpf);
            txtNome.Text = vip.nome;
            txtNascimento.Text = vip.nascimento;
            txtEmail.Text = vip.email;
            txtCelular.Text = vip.celular;
            txtCidade.Text = vip.cidade;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Vip vip = new Vip();
            vip.Inserir(txtNome.Text, txtNascimento.Text, txtEmail.Text, txtCelular.Text, txtCidade.Text);
            MessageBox.Show("Cadastro realizado com sucesso!");
            List<Vip> vips = vip.listavip();
            dgvClientes.DataSource = vips;
            txtNome.Text = "";
            txtNascimento = "";
            txtEmail.Text = "";
            txtCelular.Text = "";
            txtCidade.Text = "";
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            int Cpf = Convert.ToInt32(txtcpf.Text.Trim());
            Vip vip = new Vip();
            vip.Atualizar(Cpf, txtNome.Text, txtNascimento.Text, txtEmail.Text, txtCelular.Text, txtCidade.Text);
            MessageBox.Show("Cadastro atualizado com sucesso!");
            List<Vip> vips = vip.listavip();
            dgvClientes.DataSource = vips;
            txtNome.Text = "";
            txtNascimento = "";
            txtEmail.Text = "";
            txtCelular.Text = "";
            txtCidade.Text = "";
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int Cpf = Convert.ToInt32(txtCpf.Text.Trim());
            Vip vip = new Vip();
            vip.Exclui();
            MessageBox.Show("Cadastro excluído com sucesso!");
            List<Vip> vips = vip.listavip();
            dgvClientes.DataSource = vips;
            txtNome.Text = "";
            txtNascimento = "";
            txtEmail.Text = "";
            txtCelular.Text = "";
            txtCidade.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
