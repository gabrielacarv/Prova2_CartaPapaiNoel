using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class Endereco
    {
        [Required(ErrorMessage = "Rua é obrigatório!")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Número é obrigatório!")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Bairro é obrigatório!")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatório!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Estado é obrigatório!")]
        public string Estado { get; set; }
    }
}
