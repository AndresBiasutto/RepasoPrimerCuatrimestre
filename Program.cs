using System.Security.AccessControl;

namespace repasoPrimerCuatrimestre;

class Program
{
    static void Main(string[] args)
    {
        string? option;
        string? goBack;

        School escuela = new School("El Tupac");
        do
        {
            Console.Clear();
            Console.WriteLine($"Escuela: {escuela.Name}");
            Console.WriteLine("Que vas a hacer?");
            Console.WriteLine("1 - Inscribir alumno.");
            Console.WriteLine("2 - Ver estudiantes inscriptos");
            Console.WriteLine("3 - Ver promedios de los estudiantes.");
            Console.WriteLine("4 - Expulsar alumno.");
            Console.WriteLine("EXIT - Salir.");
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    string? continueAddingStudents;
                    do
                    {
                        Console.WriteLine("Agregar alumno");
                        Console.WriteLine("===================================");
                        Console.Write("Nombre: ");
                        string? studentName = Console.ReadLine();
                        Console.Write("Edad: ");
                        string? studentAge = Console.ReadLine();
                        int age = 0;
                        if (!string.IsNullOrEmpty(studentAge))
                        {
                            int.TryParse(studentAge, out age);
                        }
                        Console.WriteLine(escuela.EnrollStudent(studentName ?? "noName", age));
                        Console.WriteLine("===================================");
                        Console.WriteLine("¿Desea agregar otro estudiante? (S/N)");
                        continueAddingStudents = Console.ReadLine();
                    } while (continueAddingStudents != null && continueAddingStudents.ToLower() == "s");
                    break;
                case "2":
                    do
                    {
                        Console.WriteLine("Lista de estudiantes inscriptos:");
                        Console.WriteLine("===================================");
                        Console.WriteLine(escuela.ListStudentsNames());
                        Console.WriteLine("===================================");
                        Console.WriteLine("¿Desea volver al menú anterior? (S/N)");
                        goBack = Console.ReadLine();
                    } while (goBack != null && goBack.ToLower() != "s");
                    break;
                case "3":
                    do
                    {
                        Console.WriteLine("Promedios de los estudiantes:");
                        Console.WriteLine("===================================");
                        Console.WriteLine(escuela.ListStudentsGrades());
                        Console.WriteLine("===================================");
                        Console.WriteLine("¿Desea volver al menú anterior? (S/N)");
                        goBack = Console.ReadLine();
                    } while (goBack != null && goBack.ToLower() != "s");
                    break;
                case "4":
                    do
                    {
                        Console.WriteLine("A quien vas a expulsar de la institución?");
                        Console.WriteLine("===================================");
                        string? studentNameToDelete = Console.ReadLine();
                        Console.WriteLine(escuela.RemoveStudent(studentNameToDelete ?? "noName"));
                        Console.WriteLine("===================================");
                        Console.WriteLine("¿Desea volver al menú anterior? (S/N)");
                        goBack = Console.ReadLine();
                    } while (goBack != null && goBack.ToLower() != "s");

                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("opcion no valida");
                    break;
            }
            // Console.WriteLine("\n¿Querés hacer algo más? (S/N)");
            // continueProgram = Console.ReadLine();
        } while (option != null && option.ToLower() != "exit");
        Console.WriteLine("nos vemos");
        Console.ReadKey();
    }
}
