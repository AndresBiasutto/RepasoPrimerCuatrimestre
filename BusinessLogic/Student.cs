namespace repasoPrimerCuatrimestre;

public class Student : Human
{
    private int AlgebraGrade { get; set; }
    private int MathAnalysisGrade { get; set; }
    private int ProgrammingGrade { get; set; }

    public Student(string name, int age, int algebraGrade= 0, int mathAnalysisGrade= 0, int programmingGrade= 0) : base(name, age)
    {
        this.AlgebraGrade = algebraGrade;
        this.MathAnalysisGrade = mathAnalysisGrade;
        this.ProgrammingGrade = programmingGrade;
    }

    public string ShowSubjectGrades()
    {
        return $"Algebra: {AlgebraGrade}; Analisis Matematico: {MathAnalysisGrade}; Porgramación: {ProgrammingGrade}";
    }
}