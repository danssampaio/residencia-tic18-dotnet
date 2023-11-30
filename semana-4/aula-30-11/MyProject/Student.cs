public class Student
{
    public string? Name { get; set; }
    public int Idade { get; set; }

    public Student(string? name = "", int idade = 0)
    {
        Name = name;
        Idade = idade;
    }



}
