namespace KakiBoard.Domain.Tarefa.Services
{
    public interface ITarefaApplicationService
    {
        Models.Tarefa Adicionar(Commands.TarefaCommand command);
        Models.Tarefa Atribuir(Commands.TarefaCommand command);
        Models.Tarefa Entregar(Commands.TarefaCommand command);
    }
}