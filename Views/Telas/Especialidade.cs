using System;
using Controllers;
using Models;

namespace Views
{
    public class EspecialidadeViews
    {

        public static void InserirEspecialidade()
        {
            Console.WriteLine("Digite a Descrição da Especialidade: ");
            string Descricao = Console.ReadLine();
            Console.WriteLine("Digite a Tarefa da Especialidade: ");
            string Tarefas = Console.ReadLine();


            EspecialidadeController.InsertEspecialidade(
                Descricao,
                Tarefas
            );

        }
       public static void AlterarEspecialidade()
        {
            int Id = 0;
            Console.WriteLine("Digite o ID da Especialidade: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }
            Console.WriteLine("Digite a Descrição da Especialidade: ");
            string Descricao = Console.ReadLine();
            Console.WriteLine("Digite a Tarefa da Especialidade: ");
            string Tarefa = Console.ReadLine();

            EspecialidadeController.UpdateEspecialidade(
                Id,
                Descricao,
                Tarefa
            );

        }
        public static void ExcluirEspecialidade()
        {
            int Id = 0;
            Console.WriteLine("Digite o ID da Especialidade: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }
            
            EspecialidadeController.DeleteEspecialidade(
                Id
            );

        }
        public static void ListarEspecialidades()
        {
            foreach (Especialidade item in EspecialidadeController.SelectEspecialidade())
            {
                Console.WriteLine(item);
            }
        }
    }
}