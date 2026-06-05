using System.Drawing;
using System.Windows.Forms;

namespace validadordeCPF
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtCPF;
        private Button btnVerificar;
        private Button btnLimpar;
        private Button btnSair;
        private Label Resultado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtCPF = new TextBox();
            btnVerificar = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            Resultado = new Label();

            SuspendLayout();

            // txtCPF
            txtCPF.Location = new Point(50, 50);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(200, 23);

            // btnVerificar
            btnVerificar.Location = new Point(50, 100);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(120, 40);
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;

            // btnLimpar
            btnLimpar.Location = new Point(200, 100);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(120, 40);
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;

            // btnSair
            btnSair.Location = new Point(350, 100);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(120, 40);
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;

            // Resultado
            Resultado.Location = new Point(50, 170);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(300, 30);
            Resultado.Text = "";

            // Form1
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(txtCPF);
            Controls.Add(btnVerificar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(Resultado);

            Text = "Validador de CPF";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}