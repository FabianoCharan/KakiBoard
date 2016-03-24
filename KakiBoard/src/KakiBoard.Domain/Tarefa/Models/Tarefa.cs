using System;
using System.Collections.Generic;
using KakiBoard.Domain.Tarefa.Scopes;
using KakiBoard.SharedKernel.Enumeradores;

namespace KakiBoard.Domain.Tarefa.Models
{
    public class Tarefa
    {

        public Tarefa(string titulo, string tipo, string projeto, string quemCadastrou, string status)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Tipo = tipo;
            Projeto = projeto;
            QuemCadastrou = quemCadastrou;
            DataCadastro = DateTime.Now;
            Status = status;
        }

        public Tarefa(string titulo, string tipo, string projeto, string quemCadastrou, string status, IList<string> tags) : this(titulo, tipo, projeto, quemCadastrou, status)
        {
            Tags = tags;
        }

        public Guid Id { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public string Tipo { get; private set; }
        public string Projeto { get; private set; }
        public IList<string> Tags { get; private set; }
        public string ResponsavelNegocio { get; private set; }
        public string ResponsavelTecnico { get; private set; }
        public string QuemCadastrou { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime? DataEntrega { get; private set; }
        public DateTime? DataAprovacao { get; private set; }
        public string Status { get; private set; }
        public int? TempoEstimado { get; private set; }
        public int? TempoGasto { get; private set; }

        public IList<Interacao> Interacoes { get; private set; }
        public IList<Teste> Testes { get; private set; }

        public void AdicionarTarefa()
        {
            this.AdicionarTarefaEscopoValido();
        }

        public void AtribuirTarefa()
        {
            this.AtribuirTarefaEscopoValido();
        }

        public void EntregarTarefa()
        {
            DataEntrega = DateTime.Now;
            Status = StatusTarefa.Done.ToString();

            this.EntregarTarefaEscopoValido();
        }

    }
}