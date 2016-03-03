using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KakiBoard.Domain.Task.Models
{
    public class Task
    {
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public string Tipo { get; private set; }
        public string Projeto { get; private set; }
        public string Tags { get; private set; }
        public string ResponsavelNegocio { get; private set; }
        public string ResponsavelTecnico { get; private set; }
        public string QuemCadastrou { get; private set; }
        public DateTime DataCadastro { get; set; }
        public string Status { get; private set; }
        public int TempoEstimado { get; private set; }
        public int TempoGasto { get; private set; }
        public int MyProperty { get; set; }

        public Task()
        {

        }
    }
}
