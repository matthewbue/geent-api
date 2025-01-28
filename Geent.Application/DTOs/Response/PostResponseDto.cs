using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geent.Application.DTOs.Response
{
    public class PostResponseDto
    {
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        public int LikeTotal { get; set; }
        public DateTime CreationDate { get; set; }
        public string? UserCreation { get; set; }
        public string? Id { get; set; }
        public string? Author { get; set; }
        public string? Content { get; set; }
        public int LightningCount { get; set; } 
        public int CommentCount { get; set; }
    }
}
