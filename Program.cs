
Console.WriteLine("C# condiciones");

Console.WriteLine("Porfavor ingrese la nota del estudiante");
double grade = Double.Parse (Console.ReadLine() ?? "0");
Console.WriteLine("El estudiante pago (y/n)");
//bool paid = (Console.ReadLine() == "y");
bool paid;
string input = Console.ReadLine() ?? "n";
if (input == "y")
{
    paid = true;
} else {
    paid = false;
}

if (grade >= 70)
{
    if (paid)
    {
        Console.WriteLine("Felicidades!");
    } else {
        Console.WriteLine("Necesitas pagar la graduacion");
    }
} else {
    Console.WriteLine("No esta graduado");
}

Console.WriteLine("Programa terminado!");