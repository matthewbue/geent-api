using Geent.Application.DTOs.Request;
using Geent.Application.DTOs.Response;
using Geent.Application.Interface.Service;
using Geent.Domain.Entidade;
using Geent.Domain.Interface;
using Geent.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geent.Application.Service
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository configuration)
        {
            _postRepository = configuration;
        }

        public async Task CreatePost(Post post)
        { 
          await _postRepository.CreatePost(post);
        }

        public async Task<List<Post>> GetAll(string userCreation)
        {  

           var posts =  await _postRepository.GetAll(userCreation); 

            return posts;
        }

        public async Task<List<PostResponseDto>> GetAllByUserCreation(string userCreation)
        {
            // Simulação de dados mockados
            var mockPosts = new List<PostResponseDto>
    {
        new PostResponseDto
        {
            Id = "1",
            Author = "abreunegocio@gmail.com",
            Content = "Alguém tem o HQ de Dragonball Z?",
            LightningCount = 28,
            CommentCount = 75
        },
        new PostResponseDto
        {
            Id = "2",
            Author = "abreunegocio@gmail.com",
            Content = "Vocês já conhecem os benefícios da Cannabis?",
            LightningCount = 45,
            CommentCount = 102
        }
    };  

            // Filtro por userCreation
            var filteredPosts = mockPosts.Where(post => post.Author == userCreation).ToList();

            // Retorna a lista como uma Task
            return await Task.FromResult(filteredPosts);
        }


        public async Task<List<Midia>> GetAllMidias(int type)
        {

            var midias = await _postRepository.GetAllMidias(type);

            return midias;
        }

        public async Task<Midia> GetMidiaById(int id)
        {

            var midias = await _postRepository.GetMidiaId(id);

            return midias;
        }
    }
}
