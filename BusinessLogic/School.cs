namespace repasoPrimerCuatrimestre;

public class School
{
    public string Name { get; set; }
    private List<Student> Students { get; set; }

    public School(string name)
    {
        this.Name = name;
        this.Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
    public void ListStudentsGrades()
    {
        for (int i = 0; i < Students.Count; i++)
        {
            Console.WriteLine($"");
            Console.WriteLine($"Nombre: {Students[i].Name}.");
            Console.WriteLine($"Notas: {Students[i].ShowSubjectGrades()}.");
            Console.WriteLine($"");
        }
    }
    public void ListStudentsNames()
    {
        int numberOfStudents = Students.Count;
        int iterator = 0;
        Console.WriteLine("Estudiantes inscriptos");
        while (iterator < numberOfStudents)
        {
            Console.WriteLine($"Nombre: {Students[iterator].Name}.");
            Console.WriteLine($"Edad: {Students[iterator].Age}.");

            iterator++;
        }
    }
}