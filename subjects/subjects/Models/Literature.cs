using System.ComponentModel.DataAnnotations;

namespace subjects.Models
{
    public class Literature : BaseObject
    {

        public int Year { get; set; }

        public List<Author> Authors { get; set; } = new List<Author>();

        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
