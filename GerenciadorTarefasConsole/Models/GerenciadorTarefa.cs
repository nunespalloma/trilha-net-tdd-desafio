using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorTarefasConsole.Models
{
    public class GerenciadorTarefa
    {
        public List<Tarefa> Tarefas { get; set; }

        public GerenciadorTarefa ()
        {
            Tarefas = new List<Tarefa>();
        }

        //Adicionando tarefa
        public void AdicionarTarefa(Tarefa tarefa)
        {
            Tarefas.Add(tarefa);
        }

        //Removendo tarefa
        public void RemoverTarefa(String nome)
        {
            Tarefa tarefaASerRemovida = new Tarefa();
            foreach(Tarefa tarefa in Tarefas)
            {
                if (tarefa.Nome == nome)
                {
                    tarefaASerRemovida = tarefa;
                }
            }
            Tarefas.Remove(tarefaASerRemovida);
        }

        //Concluindo tarefa
        public void ConcluirTarefa(String nome)
        {
            foreach(Tarefa tarefa in Tarefas)
            {
                if (tarefa.Nome == nome)
                {
                    tarefa.EstahConcluida = true;
                }
            }
        }

        //Verificando se uma tarefa já está na lista de tarefas
        public bool VerificarTarefaNaLista(String nome)
        {
            foreach(Tarefa tarefa in Tarefas)
            {
                if (tarefa.Nome == nome)
                {
                    return true;
                }
            }
            return false;
        }

        //Trazendo histórico das últimas 2 tarefas adicionadas à lista de tarefas
        public List<Tarefa> TrazerHistoricoDuasUltimasTarefas()
        {
            List<Tarefa> historico = new List<Tarefa>();
            if (Tarefas.Count() > 2){
                historico = Tarefas.GetRange(Tarefas.Count - 2, 2);
            }
            return historico;
        }
    }
}