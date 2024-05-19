using GerenciadorTarefasConsole.Models;

namespace GerenciadorTarefasTests;

public class GerenciadorTarefaTest
{
    GerenciadorTarefa gerenciadorTarefa = new GerenciadorTarefa();

    //Verificando se está adicionando tarefa
    [Fact]
    public void DeveVerificarSeEstaAdicionandoLavarLoucaNaListaTarefas()
    {
        //Arrange
        Tarefa tarefa = new Tarefa("Lavar louça",false);
        
        //Act
        gerenciadorTarefa.AdicionarTarefa(tarefa);

        //Assert
        Assert.Contains(tarefa, gerenciadorTarefa.Tarefas);
    }

    //Verificando se está removendo tarefa
    [Fact]
    public void DeveVerificarSeEstaRemovendoLavarLoucaDaListaTarefas()
    {
        //Arrange
        Tarefa tarefa = new Tarefa("Lavar louça",false);
        
        //Act
        gerenciadorTarefa.RemoverTarefa(tarefa.Nome);

        //Assert
        Assert.DoesNotContain(tarefa, gerenciadorTarefa.Tarefas);
    }

    //Verificando se está concluindo tarefa
    [Fact]
    public void DeveVerificarSeEstaConcluindoATarefaLavarLouca()
    {
        //Arrange
        Tarefa tarefa = new Tarefa("Lavar louça",false);
        
        //Act
        gerenciadorTarefa.ConcluirTarefa(tarefa.Nome);

        //Assert
        Assert.True(tarefa.EstahConcluida);
    }

    //Verificando a seguinte checagem: se uma tarefa já está na lista de tarefas
    [Fact]
    public void DeveVerificarSeTarefaLavarLoucaEstaNaLista()
    {
        //Arrange
        Tarefa tarefa = new Tarefa("Lavar louça",false);
        gerenciadorTarefa.Tarefas.Add(tarefa);
        
        //Act
        var resultado = gerenciadorTarefa.VerificarTarefaNaLista(tarefa.Nome);

        //Assert
        Assert.True(resultado);
    }

    //Verificando a seguinte checagem: se uma tarefa não está na lista de tarefas
    [Fact]
    public void DeveVerificarSeTarefaLavarLoucaNaoEstaNaLista()
    {
        //Arrange
        Tarefa tarefa = new Tarefa("Lavar louça",false);
        gerenciadorTarefa.Tarefas.Remove(tarefa);
        
        //Act
        var resultado = gerenciadorTarefa.VerificarTarefaNaLista(tarefa.Nome);

        //Assert
        Assert.False(resultado);
    }

    //Verificando histórico das últimas 2 tarefas adicionadas à lista de tarefas
    [Fact]
    public void DeveVerificarHistoricoDasDuasUltimasTarefasAdicionadasNaLista()
    {
        //Arrange
        Tarefa tarefaA = new Tarefa("Tarefa A",false);
        Tarefa tarefaB = new Tarefa("Tarefa B",false);
        gerenciadorTarefa.Tarefas.Add(tarefaA);
        gerenciadorTarefa.Tarefas.Add(tarefaB);
        List<Tarefa> historico = new List<Tarefa>();
        historico.Add(tarefaA);
        historico.Add(tarefaB);
        
        //Act
        var resultado = gerenciadorTarefa.TrazerHistoricoDuasUltimasTarefas();

        //Assert
        Assert.Equal(historico,resultado.GetRange(resultado.Count - 2, 2));
    }

}