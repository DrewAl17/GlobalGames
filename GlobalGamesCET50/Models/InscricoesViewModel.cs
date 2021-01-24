using GlobalGamesCET50.Dadoss.Entidades;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCET50.Models
{
    public class InscricoesViewModel : Inscricoes
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
