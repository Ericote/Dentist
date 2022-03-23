using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Repository;
using System.Linq;

namespace Models
{
    public class Paciente : Pessoa
    {
        [Required]
        public DateTime DataNascimento { set; get; }

        public override string ToString()
        {
            return base.ToString()
                + $"\nData de Nascimento: {this.DataNascimento}";
        }

        public Paciente()
        {}

        public Paciente(
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            string Senha,
            DateTime DataNascimento
        ) : base(Nome, Cpf, Fone, Email, Senha)
        {
            this.DataNascimento = DataNascimento;
            Context db = new Context();
            db.Pacientes.Add(this);
            db.SaveChanges();
        }

        public static List<Paciente> GetPacientes()
        {
            Context db = new Context();
            return (from Paciente in db.Pacientes select Paciente).ToList();
        }

        public static void RemoverPaciente(Paciente paciente)
        {
            Context db = new Context();
            db.Pacientes.Remove(paciente);
        }

    }
}