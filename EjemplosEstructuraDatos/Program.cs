using EjemplosEstructuraDatos;

List<Alumno> lista = new List<Alumno>();

Alumno alumno1 = new Alumno();
alumno1.Nombres = "Antonio";
alumno1.ApellidoPaterno = "Rogel";
alumno1.Matricula = "123";
alumno1.FechaNacimiento = DateTime.Now;


Alumno alumno2 = new Alumno();
alumno2.Nombres = "Juan";
alumno2.ApellidoPaterno = "Lopez";
alumno2.Matricula = "456";
alumno2.FechaNacimiento = new DateTime(1980, 02, 28);

Alumno alumno3 = new Alumno();
alumno3.Nombres = "Juan";
alumno3.ApellidoPaterno = "Lopez";
alumno3.Matricula = "456";
alumno3.FechaNacimiento = new DateTime(1980, 02, 28);

lista.Add(new Alumno());
lista[0].Nombres = "Daniel Raymundo";
lista.Add(alumno1);
lista[1].Nombres = "Pedro";
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