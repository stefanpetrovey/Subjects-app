namespace subjects.Models
{
    public class Subject : BaseObject, InterfaceLiterature
    {

        public string Description { get; set; }
        public int NumWeeklyClasses { get; set; }
        public string Image { get; set; }
        public List<Literature> Literatures { get; set; } = new List<Literature>();
    }
}
