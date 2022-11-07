using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCasesDTOs.ListAlbum
{
    public class ListAlbumResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Artist { get; set; }
        public int Year { get; set; }
        public string? ImageURL { get; set; }
        public bool Status { get; set; }
    }
}
