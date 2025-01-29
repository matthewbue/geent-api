using Geent.Application.Interface.Service;
using Geent.Domain.Entidade;
using Geent.Domain.Interface;
using Geent.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geent.Application.Service
{
    public class MidiaService : IMidiaService
    {
        private readonly IMidiaRepository _midiaRepository;
        
        public MidiaService(IMidiaRepository midiaRepository)
        {
            _midiaRepository = midiaRepository;
        }
        public async Task<List<Midia>> GetAllMidias(int type)
        {

            var midias = await _midiaRepository.GetAllMidias(type);
            return midias;

        }
        public async Task<Midia> GetMidiaById(int id)
        {
            var midias = await _midiaRepository.GetMidiaId(id);
            return midias;
        }
    }
}
