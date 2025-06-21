namespace repasoPrimerCuatrimestre;

class Program
{
    static void Main(string[] args)
    {
        string? option;
        string? continueProgram;
        Student estudiante1 = new Student("Andres", 40, 10, 7, 10);
        Student estudiante2 = new Student("Pedrito", 19, 4, 7, 1);
        Student estudiante3 = new Student("Juanita", 79, 10, 10, 10);
        School escuela = new School("El Tupac");
        escuela.AddStudent(estudiante1);
        escuela.AddStudent(estudiante2);
        escuela.AddStudent(estudiante3);

        do
        {
            Console.Clear();
            Console.WriteLine($"Escuela: {escuela.Name}");
            Console.WriteLine("Que vas a hacer?");
            Console.WriteLine("1 - Ver estudiantes inscriptos.");
            Console.WriteLine("2 - Ver promedios de los estudiantes.");
            Console.WriteLine("3 - Terminar.");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    escuela.ListStudentsNames();
                    break;
                case "2":
                    escuela.ListStudentsGrades();
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("opcion no valida");
                    break;
            }

            Console.WriteLine("\n¿Querés hacer algo más? (S/N)");
            continueProgram = Console.ReadLine();

        } while (continueProgram != null && continueProgram.ToLower() == "s");

        Console.WriteLine("nos vemos");
        Console.ReadKey();

    }
}
