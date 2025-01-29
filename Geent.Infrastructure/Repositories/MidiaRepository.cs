using Geent.Domain.Entidade;
using Geent.Domain.Interface;
using Geent.Infrastructure.ConfigurationDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geent.Infrastructure.Repositories
{
    public class MidiaRepository : IMidiaRepository
    {
        private readonly PostgresDbContext _context;

        public MidiaRepository(PostgresDbContext context)
        {
            _context = context;
        }

        public async Task<List<Midia>> GetAllMidias(int type)
        {
            return await _context.Midia.Where(t => t.Type == type).ToListAsync();
        }

        public async Task<Midia> GetMidiaId(int id)
        {
            return await _context.Midia.Where(t => t.Id == id).FirstOrDefaultAsync();
        }
    }
}
