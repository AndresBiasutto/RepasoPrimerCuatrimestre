namespace repasoPrimerCuatrimestre;

public class Human
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public Human(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string sayHi()
    {
        return $"Hola, mi nombre es {Name} y tengo {Age} años.";
    }

}