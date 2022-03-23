using System;
using Controllers;
using Models;
using Views;

namespace Views
{
    public class AgendamentoProcedimentoViews
    {
        public static void InserirAgendamentoProcedimento()
        {
            Console.WriteLine("\n Informe o Id do Agendamento: ");
            int IdAgendamento = Convert.ToInt32(Console.ReadLine());
            ProcedimentoViews.ListarProcedimentos();
            Console.WriteLine("\n Informe o Id do Procedimento: ");
            int IdProcedimento = Convert.ToInt32(Console.ReadLine());
            AgendamentoProcedimentoControllers.InsertAgendamentoProcedimento(IdAgendamento, IdProcedimento);
        }

        public static void AlterarAgendamentoProcedimento()
        {
            int Id = 0;
            int IdProcedimento = 0;
            int IdAgendamento = 0;
            Console.WriteLine("Digite o ID do Agendamento Procedimento: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }
            Console.WriteLine("Digite o ID do Agendamento: ");
            try
            {
                IdAgendamento = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }
            Console.WriteLine("Digite o ID do Procedimento: ");
            try
            {
                IdProcedimento = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }

            AgendamentoProcedimentoControllers.UpdateAgendamentoProcedimento(
                Id,
                IdAgendamento,
                IdProcedimento
            );
        }

        public static void ExlcuirAgendamentoProcedimento()
        {
            int Id = 0;
            Console.WriteLine("Digite o ID do Agendamento Procedimento: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }
            
            AgendamentoProcedimentoControllers.DeleteAgendamentoProcedimento(
                Id
            );
        }

        public static void ListarAgendamentoProcedimento()
        {
            foreach (AgendamentoProcedimento item in AgendamentoProcedimentoControllers.VisualizarAgendamentoProcedimento())
            {
                Console.WriteLine(item);
            }
        }
    }
}