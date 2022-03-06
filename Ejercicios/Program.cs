float horas, precioHora, salario;
string nombre;
bool masDatos;

Console.WriteLine("Introduce el nombre del empleado");
nombre = Console.ReadLine();

Console.WriteLine("Intoduce cantidad de horas trabajadas");
horas = float.Parse (Console.ReadLine());

Console.WriteLine("Intoduce el precio de la hora");
precioHora = float.Parse(Console.ReadLine());

do
{
    if (horas <= 40)
    {
        salario = horas * precioHora;
    }
    else
    {
        salario =(40* precioHora) + 3/2 * (horas - 40) * precioHora;
    }
    Console.WriteLine("Salario de " + nombre + salario);
    Console.WriteLine("Si desea ingresar más trabajadores digite true sino digite false");
    masDatos = bool.Parse(Console.ReadLine());
} while (masDatos == true);







