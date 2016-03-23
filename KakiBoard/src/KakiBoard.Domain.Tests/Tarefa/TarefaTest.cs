﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using KakiBoard.SharedKernel.Enumeradores;
using KakiBoard.Domain.Tarefa.Scope;

namespace KakiBoard.Domain.Tests.Tarefa
{
    [TestClass]
    public class TarefaTest
    {
        [TestMethod]
        [TestCategory("Tarefa")]
        public void DeveLancarNovaTarefa()
        {
            var tarefa = new Domain.Tarefa.Models.Tarefa(
                "Titulo tarefa", 
                TipoTarefa.Desenvolvimento.ToString(), 
                Projeto.BNEVip.ToString(), 
                "Charan", 
                StatusTarefa.ToDo.ToString());

            Assert.AreEqual(true, tarefa.AdicionarTarefaEscopoValido());
        }

        [TestMethod]
        [TestCategory("Tarefa")]
        public void NaoDeveLancarFaltaTitulo()
        {
            var tarefa = new Domain.Tarefa.Models.Tarefa(
                "",
                TipoTarefa.Desenvolvimento.ToString(),
                Projeto.BNEVip.ToString(),
                "Charan",
                StatusTarefa.ToDo.ToString());

            Assert.AreEqual(true, tarefa.AdicionarTarefaEscopoValido());
        }
    }
}
