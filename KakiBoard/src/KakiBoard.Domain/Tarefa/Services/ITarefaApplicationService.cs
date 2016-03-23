namespace KakiBoard.Domain.Tarefa.Services
{
    public interface ITarefaApplicationService
    {
        Models.Tarefa AdicionarTarefa(Commands.TarefaCommand command);
        Models.Tarefa AtribuirTarefa(Commands.TarefaCommand command);
        Models.Tarefa EntregarTarefa(Commands.TarefaCommand command);
    }
}