using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Repository;
using System.Linq;

namespace Models
{
    public class Especialidade
    {
        public int Id {get; set;}
        [Required]
        public string Descricao {get; set;}
        [Required]
        public string Tarefas {get; set;}
        
        public Especialidade()
        {
        }
        public Especialidade(string Descricao,
                             string Tarefas)
        {
            this.Descricao = Descricao;
            this.Tarefas = Tarefas;

            Context db = new Context();
            db.Especialidades.Add(this);
            db.SaveChanges();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!Especialidade.ReferenceEquals(obj, this))
            {
                return false;
            }
            Especialidade it = (Especialidade) obj;
            return it.Id == this.Id;
        }

        public override string ToString()
        {
            return "\n\n======================= \n" 
                + $"ID: {this.Id}"
                + $"\n Descrição: {this.Descricao}"
                + $"\n Tarefas: {this.Tarefas}";
        }

        public static List<Especialidade> GetEspecialidades()
        {
            Context db = new Context();
            return (from Especialidade in db.Especialidades select Especialidade).ToList();
        }

        public static void RemoverEspecialidade(Especialidade especialidade)
        {
            Context db = new Context();
            db.Especialidades.Remove(especialidade);
        }

    }
}