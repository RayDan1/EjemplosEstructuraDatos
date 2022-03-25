using EjemplosEstructuraDatos;

List<Alumno> lista = new List<Alumno>();

Alumno alumno1 = new Alumno();
alumno1.Nombres = "Pedro";
alumno1.ApellidoPaterno = "Martinez";
alumno1.Matricula = "321";
alumno1.FechaNacimiento = new DateTime(1999, 5, 25);

Alumno alumno2 = new Alumno();
alumno2.Nombres = "Ingnacio";
alumno2.ApellidoPaterno = "Lopez";
alumno2.Matricula = "654";
alumno2.FechaNacimiento = new DateTime(1998, 6, 28);

Alumno alumno3 = new Alumno();
alumno3.Nombres = "Ray";
alumno3.ApellidoPaterno = "Ramirez";
alumno3.Matricula = "999";
alumno3.FechaNacimiento = new DateTime(1999, 02, 12);

lista.Add(alumno1);
lista.Add(alumno2);
lista.Add(alumno3);

foreach (Alumno alumnoEnLista in lista)
{
    Console.WriteLine(
        " Nombre: "
        + alumnoEnLista.NombreCompleto
        + " Matricula: "
        + alumnoEnLista.Matricula
        + " fecha nacimiento: "
        + alumnoEnLista.FechaNacimiento.ToString("dd-MM-yyyy"));
}