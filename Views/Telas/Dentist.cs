using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telas;

namespace Telas
{
    public class Dentist : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblMenu;
        Button btnSair;
        Button btnDentista;
        Button btnPaciente;
        Button btnSala;
        Button btnProcedimento;
        Button btnEspecialidade;
        Button btnAgendamento;

        public Dentist()
        {
            // primeiro numero é larura e o segundo é altura

            //============== Dentista ================

            this.lblMenu = new Label();
            this.lblMenu.Text = " Menu Dentista ";
            this.lblMenu.Location = new Point(115, 20);

            this.btnDentista = new ButtonField("Dentista", 40, 50, 100, 30);
            btnDentista.Click += new EventHandler(this.btnListDentistaClick);

            //============= Paciente ==============

            this.btnPaciente = new ButtonField("Paciente", 40, 90, 100, 30);
            btnPaciente.Click += new EventHandler(this.btnPacienteClick);

            //============ Sala ==============

            this.btnSala = new ButtonField("Sala", 40, 130, 100, 30);
            btnSala.Click += new EventHandler(this.btnListSalaClick);

            //============== Procedimento ===================

            this.btnProcedimento = new ButtonField("Procedimento", 170, 50, 100, 30);
            btnProcedimento.Click += new EventHandler(this.btnListProdmtClick);

            //=================== Especialista ==================

            this.btnEspecialidade = new ButtonField("Especialidade", 170, 90, 100, 30);
            btnEspecialidade.Click += new EventHandler(this.btnListEspecialidadeClick);

            //================= Agendamento ====================

            this.btnAgendamento = new ButtonField("Agendamento", 170, 130, 100, 30);
            btnAgendamento.Click += new EventHandler(this.btnListAgendamentoClick);

            //================ SAIR =====================

            this.btnSair = new ButtonField("Sair", 105, 170, 100, 30);
            btnSair.Click += new EventHandler(this.btnSairClick);


            this.Controls.Add(this.btnDentista);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnSala);
            this.Controls.Add(this.btnProcedimento);
            this.Controls.Add(this.btnEspecialidade);
            this.Controls.Add(this.btnAgendamento);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblMenu);
            
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Dentista";

        }

        //========= ABRE A TELA DA LISTA DE PACIENTES ============

            private void btnPacienteClick(object sender, EventArgs e)
            {
                Patient Patient = new Patient();
                Patient.ShowDialog();
            }

        //============ ABRE A TELA DA LISTA DE DENTISTAS ==========

             private void btnListDentistaClick(object sender, EventArgs e)
            {
                ListDentista ListDentista = new ListDentista();
                ListDentista.ShowDialog();
            }

        //=========== ABRE A TELA DA LISTA DE SALAS =================

            private void btnListSalaClick(object sender, EventArgs e)
            {
                ListSala ListSala = new ListSala();
                ListSala.ShowDialog();
            }

        //================== ABRE A TELA DA LISTA DE PROCEDIMENTOS =============

            private void btnListProdmtClick(object sender, EventArgs e)
            {
                ListProcedimento ListProcedimento = new ListProcedimento();
                ListProcedimento.ShowDialog();
            }

        //============== ABRE A TELA DA LISTA DE ESPECIALIDADE ===============

            private void btnListEspecialidadeClick(object sender, EventArgs e)
            {
                ListEspecialidade ListEspecialidade = new ListEspecialidade();
                ListEspecialidade.ShowDialog();
            }

        //=============== ABRE A TELA DA LISTA DE AGENDAMENTO ===================

            private void btnListAgendamentoClick(object sender, EventArgs e)
            {
                ListAgendamento ListAgendamento = new ListAgendamento();
                ListAgendamento.ShowDialog();
            }

        //===========================================================================

            private void btnSairClick(object sender, EventArgs e)
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

    }
}