using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Repository;
using System.Linq;

namespace Models
{
    public class AgendamentoProcedimento
    {

        public int Id {get; set;}
        [Required]
        public int AgendamentoId {get; set;}
        public Agendamento Agendamento {get;}
        [Required]
        public int ProcedimentoId {get; set;}

        public AgendamentoProcedimento()
        {}

        public AgendamentoProcedimento(int AgendamentoId,
                                        int ProcedimentoId)
        {
            this.Id = Id;
            this.AgendamentoId = AgendamentoId;
            this.ProcedimentoId = ProcedimentoId;

            Context bd = new Context();
            bd.AgendamentosProcedimentos.Add(this);
            bd.SaveChanges();
        }

        public override string ToString()
        {
            return "\n\n =======================" +
                   "\n Id: " + this.Id +
                   "\n Id Agendamento: " + this.AgendamentoId +
                   "\n Id Procedimento: " + this.ProcedimentoId;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            if(!AgendamentoProcedimento.ReferenceEquals(obj, this))
            {
                return false;
            }

            AgendamentoProcedimento it = (AgendamentoProcedimento) obj;
            return it.Id == this.Id;

        }

        public static List<AgendamentoProcedimento> GetAgendamentoProcedimentos()
        {
            Context bd = new Context();
            return (from AgendamentoProcedimento in bd.AgendamentosProcedimentos select AgendamentoProcedimento).ToList();
        }

        public static void RemoverAgendamentoProcedimento(AgendamentoProcedimento agendamentoProcedimento)
        {
            Context bd = new Context();
            bd.AgendamentosProcedimentos.Remove(agendamentoProcedimento);
        }

    }
}