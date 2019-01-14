using System;

namespace Infnet.Pos.Tcc.Application.ViewModels
{
    public class QuestaoViewModel : BaseViewModel
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public bool Ativa { get; set; }
        public Guid GrupoQuestaoId { get; set; }
        public GrupoQuestaoViewModel GrupoQuestao { get; set; }
    }
}