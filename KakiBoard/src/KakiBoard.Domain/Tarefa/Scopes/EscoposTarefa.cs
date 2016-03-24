using KakiBoard.SharedKernel.Validation;

namespace KakiBoard.Domain.Tarefa.Scopes
{
    public static class EscoposTarefa
    {

        public static bool AdicionarTarefaEscopoValido(this Models.Tarefa tarefa)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotEmpty(tarefa.Titulo, "O título da tarefa é obrigatório"),
                    AssertionConcern.AssertNotEmpty(tarefa.Tipo, "O tipo da tarefa é obrigatório"),
                    AssertionConcern.AssertNotEmpty(tarefa.Projeto, "O projeto da tarefa é obrigatório"),
                    AssertionConcern.AssertNotEmpty(tarefa.Status, "O status da tarefa é obrigatório")
                );
        }

        public static bool AtribuirTarefaEscopoValido(this Models.Tarefa tarefa)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotEmpty(tarefa.ResponsavelTecnico, "O Responsável técnico deve ser informado")
                );
        }

        public static bool EntregarTarefaEscopoValido(this Models.Tarefa tarefa)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotEmpty(tarefa.TempoGasto.ToString(), "Você não informou o tempo gasto na tarefa"),
                    AssertionConcern.AssertIsNull(tarefa.Testes, "Foram feitos testes na tarefa?")
                );
        }

    }
}