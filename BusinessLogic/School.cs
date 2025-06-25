namespace repasoPrimerCuatrimestre;

public class School
{
    public string Name { get; set; }
    private List<Student> Students { get; set; }
    public School(string name)
    {
        Name = name;
        Students = new List<Student>();
    }
    public string ListStudentsGrades()
    {
        string studentGrades = string.Empty;
        for (int i = 0; i < Students.Count; i++)
        {
            studentGrades += $"\b\nNombre: {Students[i].Name}.\b\nNotas: {Students[i].ShowSubjectGrades()}.\b\n";
        }
        return studentGrades;
    }
    public string ListStudentsNames()
    {
        int numberOfStudents = Students.Count;
        int iterator = 0;
        string allStudents = string.Empty;
        while (iterator < numberOfStudents)
        {
            allStudents += $"Nombre: {Students[iterator].Name}. Edad: {Students[iterator].Age}. \b\n";
            iterator++;
        }
        return allStudents;
    }
    public string EnrollStudent(string studentName, int studentAge)
    {

        Student NewStudent = new Student(studentName ?? "noName", studentAge);
        Students.Add(NewStudent);
        return $"El Estudiante {NewStudent.Name} fue inscripto correctamente";

    }
    public string RemoveStudent(string studentNameToDelete)
    {

        if (string.IsNullOrWhiteSpace(studentNameToDelete))
        {
            return $"{studentNameToDelete} no existe.";
        }
        Student? studentToRemove = Students.FirstOrDefault(s => s.Name != null && s.Name.ToLower() == studentNameToDelete.ToLower());
        if (studentToRemove != null)
        {
            Students.Remove(studentToRemove);
            return $"El estudiante {studentNameToDelete} ha sido eliminado.";
        }
        else
        {
            return $"No se encontró un estudiante con el nombre {studentNameToDelete}.";
        }
    }
}