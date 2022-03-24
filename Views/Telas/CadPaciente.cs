using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers;

namespace Telas
{
    public class CadPaciente : Form
    {
        private System.ComponentModel.IContainer components = null;
        Label lblNome;
        Label lblEmail;
        Label lblCPF;
        Label lblTelefone;
        Label lblSenha;
        Label lblDataNasc;

        TextBox txtNome;
        TextBox txtEmail;
        TextBox txtCPF;
        TextBox txtTelefone;
        TextBox txtSenha;
        TextBox txtDataNasc;

        Button btnConfirmar;
        Button btnCancelar;

        public CadPaciente()
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

            //================== Label e txt Data Nasc ==================

            this.lblDataNasc = new Label();
            this.lblDataNasc.Text = "Data de Nasc";
            this.lblDataNasc.Location = new Point(330, 150);

            this.txtDataNasc = new TextBox();
            this.txtDataNasc.Location = new Point(275, 180);
            this.txtDataNasc.Size = new Size(180, 20);

            //=========== Confirmar =============

            this.btnConfirmar = new ButtonField("Confirmar", 100, 220, 100, 30);
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);

            //========== Cancelar ===============

            this.btnCancelar = new ButtonField("Cancelar", 315, 220, 100, 30);
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);


            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Cadastro de Paciente";
        }

        private void btnCancelarClick(object sender, EventArgs e)
           {
                this.Close();
           }

           public void btnConfirmarClick(object sender, EventArgs e)
        {
            string message = "Paciente cadastrado com sucesso! (Só que não, isso aqui é teste)";
            string caption = " PARABÉNS ";
            PacienteController.InserirPaciente(this.txtNome.Text,this.txtCPF.Text,this.txtTelefone.Text,this.txtEmail.Text,this.txtSenha.Text,Convert.ToDateTime(this.txtDataNasc.Text));
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