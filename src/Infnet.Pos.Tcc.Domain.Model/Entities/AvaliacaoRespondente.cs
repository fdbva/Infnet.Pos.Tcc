using System;

namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    //TODO: refatorar enum StatusEmail para Infrastructure.CrossCutting
    //criar Infrastructure.IoC para injeções
    public enum StatusEmail
    {
        AguardandoEnvio,
        Enviado,
        Erro
    }

    public class AvaliacaoRespondente : BaseEntity
    {
        public int AvaliacaoId { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public int RespondenteId { get; set; }
        public Respondente Respondente { get; set; }
        public DateTime Respondido { get; set; }
        public DateTime Enviado { get; set; }
        public StatusEmail StatusEmail { get; set; }
    }
}