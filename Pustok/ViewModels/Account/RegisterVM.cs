using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pustok.ViewModels.Account
{
    public class RegisterVM
    {
        [StringLength(maximumLength: 30)]
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength:30)]
        public string SurName { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string UserName { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
