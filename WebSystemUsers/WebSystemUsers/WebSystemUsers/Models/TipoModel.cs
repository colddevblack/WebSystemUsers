using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebSystemUsers.Models
{
    public class TipoModel
    {
        
            [Key]
        public int id { get; set; }
        public string nomeTipo { get; set; }
        public List<UsuarioModel> usuarios { get; set; }

        }
    }


