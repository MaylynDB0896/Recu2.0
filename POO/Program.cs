// See https://aka.ms/new-console-template for more information
using POO;
using POO.Modelos;

Curso curso = new Curso("Curso Test","Ubicacion","Horario");

string nombreCurso = null;

Profesor profesor = new Profesor();
profesor.Nombre = "Moises";
profesor.Apellidos = "Torres";
profesor.NumEMpleado = "123";
profesor.Especializacion = "Ing.";




CursoPresencial cursoPresencial = new CursoPresencial();
cursoPresencial.Nombre = nombreCurso != null ? nombreCurso : "Curso de programación";
cursoPresencial.Fecha = new DateTime(2023, 07, 15);
cursoPresencial.Horarios = "De 9:00 a 13:00";
cursoPresencial.NumHoras = 50;
cursoPresencial.Profesor = profesor;
Console.WriteLine("===================CURSO PRESENCIAL=============================");
Console.WriteLine($"Nombre del curso: {cursoPresencial.Nombre}");
Console.WriteLine($"Fecha del curso: {cursoPresencial.Fecha}");
Console.WriteLine($"Horarios del curso: {cursoPresencial.Horarios}");
Console.WriteLine($"Número de horas del curso: {cursoPresencial.NumHoras}");
Console.WriteLine($"El profesor del curso : {cursoPresencial.Nombre} es {cursoPresencial.Profesor.Nombre}");

Console.WriteLine(cursoPresencial.IniciarCurso(cursoPresencial.Nombre));

Console.WriteLine(cursoPresencial.PasarLista());


CursoOnline cursoOnline = new CursoOnline();
cursoOnline.Nombre = "Curso de programación";
cursoOnline.Fecha = new DateTime(2023, 07, 15);
cursoOnline.Horarios = "De 9:00 a 13:00";
cursoOnline.Ubicacion = "No aplica";
cursoOnline.Plataforma = "Plataforma Virtual";
cursoOnline.URL = "http://upqroo.edu.mx";
cursoOnline.NumHoras = 10;

Console.WriteLine("===================CURSO ONLINE=============================");

Console.WriteLine($"Nombre del curso: {cursoOnline.Nombre}");
Console.WriteLine($"Fecha del curso: {cursoOnline.Fecha}");
Console.WriteLine($"Horarios del curso: {cursoOnline.Horarios}");
Console.WriteLine($"Número de horas del curso: {cursoOnline.NumHoras}");
Console.WriteLine($"Plataforma del curso: {cursoOnline.Plataforma}");
Console.WriteLine($"Url del curso: {cursoOnline.URL}");

List<string> alumnos = new List<string>();
alumnos.Add("Moisés");
alumnos.Add("Carlos");
alumnos.Add("Ismael");
Console.WriteLine(cursoOnline.IniciarCurso(cursoOnline.Nombre));

Console.WriteLine(cursoOnline.PasarLista(alumnos));

List<Alumno> alumnosCurso = new List<Alumno>();
alumnosCurso.Add(new Alumno() { Nombre = "Moises", Apellidos= "Torres", Cuatrimestre = 1, Matricula = 123});
alumnosCurso.Add(new Alumno() { Nombre = "José", Apellidos= "Torres", Cuatrimestre = 1, Matricula = 123});
alumnosCurso.Add(new Alumno() { Nombre = "Moises", Apellidos= "Torres", Cuatrimestre = 1, Matricula = 123});


//========================ENTITYfRAMEWORK===================================================================

