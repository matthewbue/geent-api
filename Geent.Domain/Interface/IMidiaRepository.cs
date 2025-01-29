using Geent.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geent.Domain.Interface
{
    public interface IMidiaRepository
    {
        Task<Midia> GetMidiaId(int id);
        Task<List<Midia>> GetAllMidias(int type);
    }
}
