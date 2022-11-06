using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.POCOEntities
{
    public class Album
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Artist { get; set; }
        [Range(2010, 2021)]
        public int Year { get; set; }
        public string? ImageURL { get; set; }
        public bool Status { get; set; }
    }
}
