using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geent.Domain.Entidade
{
    public class Post
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? TipoMidia { get; set; }
        public string? Descricao { get; set; }
        public int Nota { get; set; }
        public string? UserCreation { get; set; }
        public int MidiaId { get; set; } // Chave estrangeira
        public Midia? Midia { get; set; } // Propriedade de navegação
    }
}
