using AutoMapper;
using Domain.Abstract.Repositories;
using Domain.Abstract.Repositories.BaseRepository;
using Domain.Abstract.Services;
using Domain.Entities;
using Domain.Models;
using Domain.Models.Auxs.DTO;
using Services.Services.BaseService;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Services
{
    public class VistoriaService : BaseService<VistoriaModel, Vistoria, IBaseRepository<Vistoria>>, IVistoriaService
    {
        private readonly IVistoriaRepository _repo;
        private readonly IAvariasService _avariasService;
        private readonly IRelatorioMecanicoService _relatorioMecanicoService;

        public VistoriaService(IVistoriaRepository repo, IMapper mapper,
            IAvariasService avariasService,
            IRelatorioMecanicoService relatorioMecanicoService) : base(repo, mapper)
        {
            _repo = repo;
            _avariasService = avariasService;
            _relatorioMecanicoService = relatorioMecanicoService;
        }

        public async Task<bool> Insert(VistoriaDTO vistoriaDTO)
        {
            // Verificando se há alguma avaria vinda no objeto.
            var temAvaria = vistoriaDTO.Componentes.Any();
            var vistoria = new Vistoria
            {
                Data = DateTime.Now,
                Descricao = vistoriaDTO.Descricao,
                TemAvaria = temAvaria
            };

            // Caso haja relatorio, já insere.
            if (vistoriaDTO.RelatorioMecanico != null)
            {
                var relatorioInserido = await _relatorioMecanicoService.Insert(vistoriaDTO.RelatorioMecanico);
                vistoria.IdRelatorioMecanico = relatorioInserido.Id;
            }

            // Inserindo a vistoria que foi configurada no decorrer.
            vistoria = await _repo.Insert(vistoria); // Inserindo a vistoria.

            // Caso haja avaria e a vistoria tenha sido inserida com sucesso.
            // Iniciará a inserção das avarias dessa vistoria.
            if (temAvaria && vistoria.Id != 0)
            {
                var avarias = vistoriaDTO.Componentes.Select(c => new AvariasModel
                {
                    IdComponente = c.Id,
                    IdVistoria = vistoria.Id,
                });

                var ok = await _avariasService.Insert(avarias);
                if (!ok) throw new Exception("Falha ao inserir avarias.");
            }

            // 
            return vistoria.Id != 0;
        }
    }
}
