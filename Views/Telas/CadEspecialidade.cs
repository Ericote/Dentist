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
    public class CadEspecialidade : Form
    {
        private System.ComponentModel.IContainer components = null;
       
        Label lblDescricao;
        Label lblTarefa;
        TextBox txtNome;
        TextBox txtDescricao;
        TextBox txtTarefa;
        Button btnConfirmar;
        Button btnCancelar;

        public CadEspecialidade()
        {

            //========== Label e Box da Tarefa =============

            this.lblTarefa = new Label();
            this.lblTarefa.Text = "Tarefa";
            this.lblTarefa.Location = new Point(130, 30);

            this.txtTarefa = new TextBox();
            this.txtTarefa.Location = new Point(60, 60);
            this.txtTarefa.Size = new Size(180, 20);

            //========== Label e Box da Descrição =============

            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(125, 90);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(60, 120);
            this.txtDescricao.Size = new Size(180, 20);

            //=========== Confirmar =============

            this.btnConfirmar = new ButtonField("Confirmar", 40, 220, 100, 30);
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);

            //========== Cancelar ===============

            this.btnCancelar = new ButtonField("Cancelar", 170, 220, 100, 30);
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);


            
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTarefa);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Cadastro da Especialidade";
        }

        private void btnCancelarClick(object sender, EventArgs e)
           {
                this.Close();
           }

           public void btnConfirmarClick(object sender, EventArgs e)
        {
            string message = "Especialidade Cadastrada com sucesso! (Só que não, isso aqui é teste)";
            string caption = " PARABÉNS ";
            EspecialidadeController.InsertEspecialidade(this.txtTarefa.Text, this.txtDescricao.Text);
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