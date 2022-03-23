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
    public class CadSala : Form
    {
        private System.ComponentModel.IContainer components = null;
        Label lblNome;
        Label lblNum;
        Label lblEquipamento;
        TextBox txtNome;
        TextBox txtNum;
        TextBox txtEquipamento;
        Button btnConfirmar;
        Button btnCancelar;

        public CadSala()
        {

            //========== Label e Box do nome =============

            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(130, 30);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(60, 60);
            this.txtNome.Size = new Size(180, 20);

            //========== Label e Box do Número =============

            this.lblNum = new Label();
            this.lblNum.Text = "Número";
            this.lblNum.Location = new Point(125, 90);

            this.txtNum = new TextBox();
            this.txtNum.Location = new Point(60, 120);
            this.txtNum.Size = new Size(180, 20);

            //========== Label e Box do CPF =============

            this.lblEquipamento = new Label();
            this.lblEquipamento.Text = "Equipamento";
            this.lblEquipamento.Location = new Point(115, 150);

            this.txtEquipamento = new TextBox();
            this.txtEquipamento.Location = new Point(60, 180);
            this.txtEquipamento.Size = new Size(180, 20);

            //=========== Confirmar =============

            this.btnConfirmar = new ButtonField("Confirmar", 40, 220, 100, 30);
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);

            //========== Cancelar ===============

            this.btnCancelar = new ButtonField("Cancelar", 170, 220, 100, 30);
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);


            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblEquipamento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtEquipamento);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Cadastro de Sala";
        }

        private void btnCancelarClick(object sender, EventArgs e)
           {
                this.Close();
           }

           public void btnConfirmarClick(object sender, EventArgs e)
        {
            string message = "Sala Cadastrada com sucesso! (Só que não, isso aqui é teste)";
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