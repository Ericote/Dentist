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
    public class CadAgendamento : Form
    {
        private System.ComponentModel.IContainer components = null;
        ListView lstPaciente;
        Label lblIdDentista;
        Label lblIdPaciente;
        Label lblData;
        Label lblSala;
        TextBox txtIdDentista;
        TextBox txtIdPaciente;
        TextBox txtData;
        TextBox txtSala;
        Button btnConfirmar;
        Button btnCancelar;

        public CadAgendamento()
        {


            lstPaciente = new ListView();
			lstPaciente.Location = new Point(100,350 );
			lstPaciente.Size = new Size(300,100);
			lstPaciente.View = View.Details;
			ListViewItem paciente1 = new ListViewItem("Elon Musk");
			paciente1.SubItems.Add("3");
			paciente1.SubItems.Add("1971");
			ListViewItem paciente2 = new ListViewItem("Rainha Elizabeth");
			paciente2.SubItems.Add("2");
			paciente2.SubItems.Add("55 AC");
			ListViewItem paciente3 = new ListViewItem("Bolsonaro");
			paciente3.SubItems.Add("1");	
			paciente3.SubItems.Add("1955");		
			lstPaciente.Items.AddRange(new ListViewItem[]{paciente1, paciente2, paciente3});
			lstPaciente.Columns.Add("Nome", -2, HorizontalAlignment.Left);
    		lstPaciente.Columns.Add("ID", -2, HorizontalAlignment.Left);
			lstPaciente.Columns.Add("Ano de Nasc", -2, HorizontalAlignment.Left);
			lstPaciente.FullRowSelect = true;
			lstPaciente.GridLines = true;
			lstPaciente.AllowColumnReorder = true;
			lstPaciente.Sorting = SortOrder.Ascending;

            //========== Label e txt ID DENTISTA =============

            this.lblIdDentista = new Label();
            this.lblIdDentista.Text = "ID Dentista";
            this.lblIdDentista.Location = new Point(340, 100);

            this.txtIdDentista = new TextBox();
            this.txtIdDentista.Location = new Point(280, 130);
            this.txtIdDentista.Size = new Size(180, 20);

            //========== Label e txt ID PACIENTE =============

            this.lblIdPaciente = new Label();
            this.lblIdPaciente.Text = "ID Paciente";
            this.lblIdPaciente.Location = new Point(100, 100);

            this.txtIdPaciente = new TextBox();
            this.txtIdPaciente.Location = new Point(40, 130);
            this.txtIdPaciente.Size = new Size(180, 20);

            //========== Label e txt Data =============

            this.lblData = new Label();
            this.lblData.Text = "Data";
            this.lblData.Location = new Point(110, 170);

            this.txtData = new TextBox();
            this.txtData.Location = new Point(40, 200);
            this.txtData.Size = new Size(180, 20);

            //============= Label e txt Sala ==============

            this.lblSala = new Label();
            this.lblSala.Text = "ID Sala";
            this.lblSala.Location = new Point(345, 170);

            this.txtSala = new TextBox();
            this.txtSala.Location = new Point(280, 200);
            this.txtSala.Size = new Size(180, 20);

            //=========== Confirmar =============

            this.btnConfirmar = new ButtonField("Confirmar", 100, 300, 100, 30);
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);

            //========== Cancelar ===============

            this.btnCancelar = new ButtonField("Cancelar", 300, 300, 100, 30);
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);


            this.Controls.Add(this.lblIdDentista);
            this.Controls.Add(this.lblIdPaciente);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.txtIdDentista);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lstPaciente);
            

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Agendamento";
        }

        private void btnCancelarClick(object sender, EventArgs e)
           {
                this.Close();
           }

           public void btnConfirmarClick(object sender, EventArgs e)
        {
            string message = "Agendamento efetuado com sucesso! (Só que não, isso aqui é teste)";
            string caption = " PARABÉNS ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
           {
            	this.Close();
           }

        }
    }
}