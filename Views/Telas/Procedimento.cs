using System;
using Controllers;
using Models;

namespace Views
{
    public class ProcedimentoViews
    {
         
         public static void InserirProcedimentos()
         {
            Console.WriteLine("Digite a Descrição do Procedimento: ");
            string Descricao = Console.ReadLine();
            Console.WriteLine("Digite o Preco do Procedimento: ");
            double Preco = Convert.ToDouble(Console.ReadLine());

            ProcedimentoControllers.InsertProcedimento(Descricao,
                                                       Preco);
         }
         public static void AlterarProcedimentos()
         {
             int Id = 0;
            Console.WriteLine("Digite o ID do Procedimento: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }

            Console.WriteLine("Digite a Descrição do Procedimento: ");
            string Descricao = Console.ReadLine();
            Console.WriteLine("Digite o Preco do Procedimento: ");
            double Preco = Convert.ToDouble(Console.ReadLine());

            ProcedimentoControllers.UpdateProcedimento(Id, Descricao, Preco);
         }
         public static void ExcluirProcedimentos()
         {
            int Id = 0;
            Console.WriteLine("Digite o ID do Procedimento: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }

            ProcedimentoControllers.DeleteProcedimento(Id);

         }
         public static void ListarProcedimentos()
         {
            foreach (Procedimento item in ProcedimentoControllers.VisualizarProcedimento())
            {
                Console.WriteLine(item);
            }
         }
    }
}