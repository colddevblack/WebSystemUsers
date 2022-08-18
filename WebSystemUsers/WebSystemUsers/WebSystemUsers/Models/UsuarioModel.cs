using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebSystemUsers.Models
{
    public class UsuarioModel
    {
        
            [Key]
            public int id { get; set; }
           public string nome { get; set; }
           public string email { get; set; }
            public string senha { get; set; }

        public string status { get; set; }



        //referencias outra model Tipo 
        public int tiposid { get; set; }
        public virtual TipoModel tipomodel { get; set; }
    }
    }


