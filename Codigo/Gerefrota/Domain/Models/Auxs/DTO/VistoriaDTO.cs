using System.Collections.Generic;

namespace Domain.Models.Auxs.DTO
{
    public class VistoriaDTO
    {
        public int IdVeiculo { get; set; }
        public IEnumerable<ComponenteModel> Componentes { get; set; }
        public string Descricao { get; set; }
        public RelatorioMecanicoModel RelatorioMecanico { get; set; }
    }
}
