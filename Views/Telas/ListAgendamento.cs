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
    public class ListAgendamento : Form
    {
		private System.ComponentModel.IContainer components = null;
        ListView lstAgendamento;
		Button btnInserir;
		Button btnUpdate;
		Button btnDelete;
		Button btnVoltar;

        public ListAgendamento()
        {
            lstAgendamento = new ListView();
			lstAgendamento.Location = new Point(50,50 );
			lstAgendamento.Size = new Size(400,320);
			lstAgendamento.View = View.Details;
			foreach (Agendamento item in AgendamentoController.VisualizarAgendamentos())
            {
                ListViewItem item2 = new ListViewItem(item.Id + "");
                item2.SubItems.Add(item.PacienteId + "");  
                item2.SubItems.Add(item.DentistaId + "");
				item2.SubItems.Add(item.SalaId + "");
				item2.SubItems.Add(item.Data + "");
                lstAgendamento.Items.AddRange(new ListViewItem[]{item2});

            }
			lstAgendamento.Columns.Add("ID", -2, HorizontalAlignment.Left);
			lstAgendamento.Columns.Add("ID Paciente", -2, HorizontalAlignment.Left);
    		lstAgendamento.Columns.Add("ID Dentista", -2, HorizontalAlignment.Left);
			lstAgendamento.Columns.Add("ID Sala", -2, HorizontalAlignment.Left);
            lstAgendamento.Columns.Add("Data", -2, HorizontalAlignment.Left);
			lstAgendamento.FullRowSelect = true;
			lstAgendamento.GridLines = true;
			lstAgendamento.AllowColumnReorder = true;
			lstAgendamento.Sorting = SortOrder.Ascending;

			//============= Inserir ===============

			this.btnInserir = new ButtonField("Inserir", 50, 380,100, 30);
			btnInserir.Click += new EventHandler(this.btnInserirClick);

			//================ Update ==================

			this.btnUpdate = new ButtonField("Update", 150, 380, 100, 30);

			//================= Delete =====================

			this.btnDelete = new ButtonField("Delete", 250, 380, 100, 30);
			btnDelete.Click += new EventHandler(this.btnDeleteClick);

			//================= Voltar =================

			this.btnVoltar = new ButtonField("Voltar", 350, 380, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lstAgendamento);

			this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Agendamentos";

			
        }

			private void btnVoltarClick(object sender, EventArgs e)
           {
            	this.Close();
           }

			public class ButtonField : Button 
        {
            public ButtonField(string Text, int x, int y, int Z, int P)
           {
            this.Text = Text;
            this.Location = new Point(x ,y);
            this.Size = new Size(Z, P);
           }
        }

		public void btnDeleteClick(object sender, EventArgs e)
        {
            string message = "Você realmente deseja deletar o Agendamento?";
            string caption = " ATENÇÃO! ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
           {
            	this.Close();
           }

        }

		private void btnInserirClick(object sender, EventArgs e)
            {
            
				CadAgendamento CadAgendamento = new CadAgendamento();
				CadAgendamento.ShowDialog();
            }

		
    }
}