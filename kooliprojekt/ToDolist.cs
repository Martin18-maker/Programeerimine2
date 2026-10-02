using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KooliProjekt.Application.Data
{

    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]

        public string Title { get; set; }

        [Required]
        public User User { get; set; }
        public int { get; set; }

    }
}
