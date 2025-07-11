# 📘 Repaso Primer Cuatrimestre - Aplicación de Consola en C#

## 🧠 Descripción

Esta es una **aplicación de consola desarrollada en C#** como ejercicio integrador para repasar los conocimientos adquiridos durante el primer cuatrimestre de la materia **Algoritmos y Estructuras de Datos**.

Permite gestionar una escuela ficticia, visualizando estudiantes inscriptos y sus calificaciones en distintas materias.

---

## 🛠️ Tecnologías utilizadas

- Lenguaje: **C#**
- Framework: **.NET**
- Entorno: **Consola**
- Paradigmas: Programación orientada a objetos (POO)

---

## 📂 Estructura del proyecto

El proyecto está compuesto por tres clases principales:

### 🔹 `Human`

Clase base que representa a cualquier ser humano.

```csharp
public class Human {
    public string? Name { get; set; }
    public int Age { get; set; }
    public string sayHi();
}
```

### 🔹 `Student` (Hereda de `Human`)

Representa a un estudiante con calificaciones en tres materias: Álgebra, Análisis Matemático y Programación.

```csharp
public class Student : Human {
    private int AlgebraGrade;
    private int MathAnalysisGrade;
    private int ProgrammingGrade;
    public string ShowSubjectGrades();
}
```

### 🔹 `School`

Gestor de estudiantes. Permite agregar alumnos y mostrar información relevante.

```csharp
public class School {
    public string Name;
    private List<Student> Students;
    public void AddStudent(Student student);
    public void ListStudentsGrades();
    public void ListStudentsNames();
}
```

---

## ▶️ Cómo usar la aplicación

1. **Cloná o descargá** el proyecto.
2. Abrí el archivo `Program.cs` en tu entorno de desarrollo (Visual Studio).
3. Ejecutá el programa.

### Menú disponible:

- `1`: Ver estudiantes inscriptos.
- `2`: Ver promedios de los estudiantes.
- `3`: Terminar el programa.

Luego de cada acción, se pregunta si el usuario desea continuar (`S/N`).

---


## 📌 Objetivo

El objetivo de esta aplicación es integrar los conocimientos de:

- Clases y herencia
- Encapsulamiento
- Colecciones (`List<T>`)
- Bucles (`do-while`, `for`, `while`)
- Control de flujo (`switch`, `if`)
- Entrada/salida por consola

---

## ✍️ Autor

**Andrés Biasutto**

Materia: *Algoritmos y estructuras de datos*  
Primer cuatrimestre – Año 2025

---

