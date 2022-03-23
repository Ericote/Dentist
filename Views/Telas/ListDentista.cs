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
    public class ListDentista : Form
    {
		private System.ComponentModel.IContainer components = null;
        ListView lstDentista;
		Button btnInserir;
		Button btnUpdate;
		Button btnDelete;
		Button btnVoltar;

        public ListDentista()
        {
            lstDentista = new ListView();
			lstDentista.Location = new Point(50,50 );
			lstDentista.Size = new Size(400,320);
			lstDentista.View = View.Details;
			ListViewItem dentista1 = new ListViewItem("Willy Wonka");
			dentista1.SubItems.Add("3");
			dentista1.SubItems.Add("Limpeza vitalicia");
			ListViewItem dentista2 = new ListViewItem("Fada do Dente");
			dentista2.SubItems.Add("2");
			dentista2.SubItems.Add("Extração Mágica");
			ListViewItem dentista3 = new ListViewItem("Mônica");
			dentista3.SubItems.Add("1");	
			dentista3.SubItems.Add("Extração bruta com coelho");		
			lstDentista.Items.AddRange(new ListViewItem[]{dentista1, dentista2, dentista3});
			lstDentista.Columns.Add("Nome", -2, HorizontalAlignment.Left);
    		lstDentista.Columns.Add("ID", -2, HorizontalAlignment.Left);
			lstDentista.Columns.Add("Especialidade", -2, HorizontalAlignment.Left);
			lstDentista.FullRowSelect = true;
			lstDentista.GridLines = true;
			lstDentista.AllowColumnReorder = true;
			lstDentista.Sorting = SortOrder.Ascending;

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
            this.Controls.Add(this.lstDentista);

			this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Dentista";

			
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
            string message = "Você realmente deseja deletar o Dentista?";
            string caption = " ATENÇÃO! ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
           {
            
            	this.Close();

           }

        }

		private void btnInserirClick(object sender, EventArgs e)
            {
            
				CadDentista CadDentista = new CadDentista();
				CadDentista.ShowDialog();
            }

		
    }
}