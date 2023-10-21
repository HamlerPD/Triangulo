// Confeccionar un programa que lea n pares de datos, cada par de datos corresponde a la
// medida de la base y la altura de un triángulo. El programa deberá informar:
//a) De cada triángulo la medida de su base, su altura y su superficie.
//b) La cantidad de triángulos cuya superficie es mayor a 12.

using System;
using System.Formats.Asn1;

double altura = 0;
double bas = 0;
double bas2 = 0;
double altura2 = 0;
double Areat1 = 0;
double Areat2 = 0;
long mayor = 12;

string linea = string.Empty;

Console.WriteLine("ingrese la base del primer triangulo ");
linea = Console.ReadLine();
bas = Convert.ToDouble(linea);

Console.WriteLine("Ingrese la altura del primer triangulo ");
linea = Console.ReadLine();
altura = Convert.ToDouble(linea);

Console.WriteLine("ingrese la base del segundo triangulo ");
linea = Console.ReadLine();
bas2 = Convert.ToDouble(linea);

Console.WriteLine("Ingrese la altura del segundo triangulo ");
linea = Console.ReadLine();
altura2 = Convert.ToDouble(linea);

Areat1 = bas * altura / 2;
Console.WriteLine(" El area del primer triangulo es: " + Areat1 + " cm² y La base igual a: " + bas + " y la altura igual: " + altura);
Areat2 = bas2 * altura2 / 2;
Console.WriteLine(" El area del primer triangulo es: " + Areat2 + " cm² y La base igual a: " + bas2 + " y la altura igual: " + altura2);



while (Areat1 > mayor)
{
    Console.WriteLine(" El area del primer triangulo es mayor a 12 ");
    break;
}
while (Areat2 > mayor)
{
    Console.WriteLine(" El area del segundo triangulo es mayor a 12 ");
    Console.ReadLine();
    break;
}