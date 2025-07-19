using System.ComponentModel.DataAnnotations;

namespace subjects.Models
{
    public abstract class BaseObject
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
