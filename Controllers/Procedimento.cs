using System;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class ProcedimentoControllers
    {
        public static Procedimento InsertProcedimento(string Descricao,
                                                      double Preco)
        {

            if(String.IsNullOrEmpty(Descricao))
            {
                throw new Exception ("Descrição inválida!");
            }

            return new Procedimento(Descricao, Preco);
        }

        // TODO
        public static Procedimento UpdateProcedimento(int Id,
                                                      string Descricao,
                                                      double Preco)
        {
            Procedimento procedimento = GetProcedimento(Id);

            if(String.IsNullOrEmpty(Descricao))
            {
                procedimento.Descricao = Descricao;
            }
            procedimento.Preco = Preco;

            return procedimento;
        }

        public static List<Procedimento> VisualizarProcedimento()
        {
            return Procedimento.GetProcedimentos();
        }

        public static Procedimento DeleteProcedimento(int Id)
        {
            Procedimento procedimento = GetProcedimento(Id);
            Procedimento.RemoverProcedimento(procedimento);
            return procedimento;
        }

        public static Procedimento GetProcedimento(int Id)
        {
            Procedimento procedimento = (
                            from Procedimento in Procedimento.GetProcedimentos()
                                where Procedimento.Id == Id
                                select Procedimento
                        ).First();

            if (procedimento == null)
            {
                throw new Exception("Procedimento não encontrado!");
            }

            return procedimento;
        }
    }
}