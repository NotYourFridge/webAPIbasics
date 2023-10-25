
public class Docent
{
    public int Id { get; set; }

    public IEnumerable<Student> Begeleidt { get; set; }

    public int? Leeftijd { get; set; }

}