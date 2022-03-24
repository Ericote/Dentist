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
			foreach (Paciente item in PacienteController.VisualizarPaciente())
            {
                ListViewItem item2 = new ListViewItem(item.Id + "");
                item2.SubItems.Add(item.Nome);  
                item2.SubItems.Add(item.Cpf);
                item2.SubItems.Add(item.Fone);
                item2.SubItems.Add(item.Email);
                item2.SubItems.Add(item.Senha);
                item2.SubItems.Add(item.DataNascimento + "");
                lstMenu.Items.AddRange(new ListViewItem[]{item2});

            }
			lstMenu.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lstMenu.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            lstMenu.Columns.Add("CPF", -2, HorizontalAlignment.Left);
    		lstMenu.Columns.Add("Telefone", -2, HorizontalAlignment.Left);
			lstMenu.Columns.Add("E-mail", -2, HorizontalAlignment.Left);
            lstMenu.Columns.Add("Senha", -2, HorizontalAlignment.Left);
            lstMenu.Columns.Add("Data de Nascimento", -2, HorizontalAlignment.Left);
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
            this.Text = " Menu Paciente ";
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