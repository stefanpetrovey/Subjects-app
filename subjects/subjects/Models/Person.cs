using System.ComponentModel.DataAnnotations;

namespace subjects.Models
{
    public abstract class Person : BaseObject
    {
        [Required]
        public string Surname { get; set; }
    }
}
