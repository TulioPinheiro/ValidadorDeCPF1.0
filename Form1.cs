using System;
using System.Windows.Forms;

namespace validadordeCPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string NumeroCPF = txtCPF.Text;

            if (NumeroCPF.Length < 11)
            {
                MessageBox.Show("Digite o cpf novamente");
                txtCPF.Text = string.Empty;
            }
            else
            {
                if (ValidacaoCpf.Verificar(NumeroCPF))
                {
                    Resultado.Text = " ESSE CPF É VALIDO";
                }
                else
                {
                    Resultado.Text = " ESSE CPF É INVALIDO";
                }
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCPF.Text = string.Empty;
            Resultado.Text = string.Empty;

            txtCPF.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}