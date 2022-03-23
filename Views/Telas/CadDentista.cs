using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telas
{
    public class CadDentista : Form
    {
        private System.ComponentModel.IContainer components = null;
        Label lblNome;
        Label lblEmail;
        Label lblCPF;
        Label lblTelefone;
        Label lblSenha;
        Label lblCRO;
        Label lblSalario;
        Label lblEspecialidade;

        TextBox txtNome;
        TextBox txtEmail;
        TextBox txtCPF;
        TextBox txtTelefone;
        TextBox txtSenha;
        TextBox txtCRO;
        TextBox txtSalario;
        TextBox txtEspecialidade;

        Button btnConfirmar;
        Button btnCancelar;

        public CadDentista()
        {

            //========== Label e Box do nome =============

            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(130, 30);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(60, 60);
            this.txtNome.Size = new Size(180, 20);

            //========== Label e Box do Email =============

            this.lblEmail = new Label();
            this.lblEmail.Text = "E-mail";
            this.lblEmail.Location = new Point(130, 90);

            this.txtEmail = new TextBox();
            this.txtEmail.Location = new Point(60, 120);
            this.txtEmail.Size = new Size(180, 20);

            //========== Label e Box do CPF =============

            this.lblCPF = new Label();
            this.lblCPF.Text = "CPF";
            this.lblCPF.Location = new Point(130, 150);

            this.txtCPF = new TextBox();
            this.txtCPF.Location = new Point(60, 180);
            this.txtCPF.Size = new Size(180, 20);

            //=============== Label e txt do Telefone ============

            this.lblTelefone = new Label();
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Location = new Point(335, 30);

            this.txtTelefone = new TextBox();
            this.txtTelefone.Location = new Point(275, 60);
            this.txtTelefone.Size = new Size(180, 20);

            //================ Label e txt Senha =====================

            this.lblSenha = new Label();
            this.lblSenha.Text = "Senha";
            this.lblSenha.Location = new Point(340, 90);

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(275, 120);
            this.txtSenha.Size = new Size(180, 20);

            //================== Label e txt Número de C.R.O ==================

            this.lblCRO = new Label();
            this.lblCRO.Text = "C.R.O";
            this.lblCRO.Location = new Point(340, 150);

            this.txtCRO = new TextBox();
            this.txtCRO.Location = new Point(275, 180);
            this.txtCRO.Size = new Size(180, 20);

            //================= Label e txt de Salário ======================

            this.lblSalario = new Label();
            this.lblSalario.Text = "Salário";
            this.lblSalario.Location = new Point(340, 210);

            this.txtSalario = new TextBox();
            this.txtSalario.Location = new Point(275, 240);
            this.txtSalario.Size = new Size(180, 20);

            //=================== Label e txt da Especialidade ===============

            this.lblEspecialidade = new Label();
            this.lblEspecialidade.Text = "Especialidade";
            this.lblEspecialidade.Location = new Point(110, 210);

            this.txtEspecialidade = new TextBox();
            this.txtEspecialidade.Location = new Point(60, 240);
            this.txtEspecialidade.Size = new Size(180, 20);

            //=========== Confirmar =============

            this.btnConfirmar = new ButtonField("Confirmar", 100, 300, 100, 30);
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);

            //========== Cancelar ===============

            this.btnCancelar = new ButtonField("Cancelar", 315, 300, 100, 30);
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);


            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblCRO);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblEspecialidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtCRO);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtEspecialidade);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Cadastro de Dentista";
        }

        private void btnCancelarClick(object sender, EventArgs e)
           {
                this.Close();
           }

           public void btnConfirmarClick(object sender, EventArgs e)
        {
            string message = "Dentista cadastrado com sucesso! (Só que não, isso aqui é teste)";
            string caption = " PARABÉNS ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
           {
            
            	this.Close();

           }

        }
    }
}