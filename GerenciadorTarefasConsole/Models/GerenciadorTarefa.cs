using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorTarefasConsole.Models
{
    public class GerenciadorTarefa
    {
        public List<Tarefa> Tarefas { get; set; }

        //Adicionando tarefa
        public void AdicionarTarefa(Tarefa tarefa)
        {
            
        }

        //Removendo tarefa
        public void RemoverTarefa(String nome)
        {
            
        }

        //Concluindo tarefa
        public void ConcluirTarefa(String nome)
        {
            
        }

        //Verificando se uma tarefa já está na lista de tarefas
        public bool VerificarTarefaNaLista(String nome)
        {
            return false;
        }

        //Trazendo histórico das últimas 2 tarefas adicionadas à lista de tarefas
        public List<Tarefa> TrazerHistoricoDuasUltimasTarefas()
        {
            return null;
        }
    }
}