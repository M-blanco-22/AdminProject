using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaVideos.Models
{

    public class Video
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; } 
        public string Nombre { get; set; }
        public string Url { get; set; }
        public string Descripcion { get; set; }
        public string Duracion { get; set; }

    }
}
