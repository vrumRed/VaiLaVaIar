using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDoVaIar.Models.DepartmentViewModels
{
    public class CreateViewModel
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Pais { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Rua { get; set; }

        [Required]
        public string CEP { get; set; }

        [Required]
        public string Numero { get; set; }
    }
}
