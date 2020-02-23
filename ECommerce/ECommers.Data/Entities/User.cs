using System.ComponentModel.DataAnnotations;

namespace ECommers.Data.Entities
{
    public class User: Abstracts.Entity
    {
        [Required, MaxLength(50), MinLength(2)]
        public string Name { get; set; }
        [Required, MaxLength(50), MinLength(2)]
        public string Surname { get; set; }
        [Required, MaxLength(50), MinLength(2)]
        public string Email { get; set; }

        //buraya geleceğiz
        public string Password { get; set; }

    }
}
