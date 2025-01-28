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
    public class PostRepository : IPostRepository
    {
        private readonly PostgresDbContext _context;

        public PostRepository(PostgresDbContext context)
        {
            _context = context;
        }

        public async Task CreatePost(Post post)
        {
            await _context.Post.AddAsync(post);
            await _context.SaveChangesAsync();

        }

        public async Task<List<Post>> GetAll(string userCreation)
        {
           
           var posts = await _context.Post.Where(c => c.UserCreation == userCreation).ToListAsync();

            return posts;
        }

        public async Task<List<Midia>> GetAllMidias(int type)
        {
            return await _context.Midia.Where(t => t.Type == type).ToListAsync();
        }

        public async Task<Midia> GetMidiaId(int id)
        {
            return await _context.Midia.Where(t => t.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Post>> GetAllByUserCreation(string userCreation)
        {
            // Simulação de dados do repositório
            return new List<Post>
        {
            new Post { Id = 1, UserCreation = "abreunegocio@gmail.com", Descricao = "Alguém tem o HQ de Dragonball Z?", Nota = 28 },
            new Post { Id = 2, UserCreation = "abreunegocio@gmail.com", Descricao = "Vocês já conhecem os benefícios da Cannabis?", Nota = 45 }
        }.Where(post => post.UserCreation == userCreation).ToList();
        }
    }
}
