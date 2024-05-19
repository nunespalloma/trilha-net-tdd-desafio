using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorTarefasConsole.Models
{
    public class Tarefa
    {
        public String Nome { get; set; }
        public bool EstahConcluida { get; set; }

        public Tarefa (){

        }
        public Tarefa (String nome, bool estahConcluida){
            Nome = nome;
            EstahConcluida = estahConcluida;
        }
    }
}