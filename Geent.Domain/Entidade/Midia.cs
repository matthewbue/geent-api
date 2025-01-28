using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geent.Domain.Entidade
{
    public class Midia
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string?  Summary { get; set; }
        public string? UrlImage { get; set; }
        public int FirstReleaseDate { get; set; }
        public int Type { get; set; }

    }
}
