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
    public class MenuPaciente : Form
    {
        private System.ComponentModel.IContainer components = null;

        Button btnConfirmar;
        Button btnSair;
        ListView lstMenu;

        public MenuPaciente()
        {
            lstMenu = new ListView();
			lstMenu.Location = new Point(30,30 );
			lstMenu.Size = new Size(240,200);
			lstMenu.View = View.Details;
			ListViewItem paciente1 = new ListViewItem("Elon Musk");
			paciente1.SubItems.Add("3");
			paciente1.SubItems.Add("1971");
			ListViewItem paciente2 = new ListViewItem("Rainha Elizabeth");
			paciente2.SubItems.Add("2");
			paciente2.SubItems.Add("55 AC");
			ListViewItem paciente3 = new ListViewItem("Bolsonaro");
			paciente3.SubItems.Add("1");	
			paciente3.SubItems.Add("1955");		
			lstMenu.Items.AddRange(new ListViewItem[]{paciente1, paciente2, paciente3});
			lstMenu.Columns.Add("Nome", -2, HorizontalAlignment.Left);
    		lstMenu.Columns.Add("ID", -2, HorizontalAlignment.Left);
			lstMenu.Columns.Add("Ano de Nasc", -2, HorizontalAlignment.Left);
			lstMenu.FullRowSelect = true;
			lstMenu.GridLines = true;
			lstMenu.AllowColumnReorder = true;
			lstMenu.Sorting = SortOrder.Ascending;

            //============== SAIR ================

            this.btnSair = new ButtonField("Sair", 30, 240, 100, 30);
            btnSair.Click += new EventHandler(this.btnSairClick);

            //============ CONFIRMAR ====================

            this.btnConfirmar = new ButtonField("Confirmar", 170, 240, 100, 30);
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);

            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnSair);
            

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = " Olá Fulano! ";
        }

            private void btnSairClick(object sender, EventArgs e)
           {
                this.Close();
           }

           public void btnConfirmarClick(object sender, EventArgs e)
        {
            string message = "Você realmente deseja fazer um agendamento?";
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
    }
}