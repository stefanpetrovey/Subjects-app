namespace subjects.Models
{
    public class Author : Person, InterfaceLiterature
    {
        public List<Literature> Literatures { get; set; } = new List<Literature>();

    }
}
