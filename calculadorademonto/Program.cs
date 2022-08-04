
Console.WriteLine("**CALCULADORA DE MONTOS**");
Console.WriteLine("");


int cantidad;
double precio;

Console.WriteLine("Por favor ingrese la cantidad seleccionada:");
cantidad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el precio del producto C$:");
precio = double.Parse(Console.ReadLine());

double Monto = cantidad * precio;

Console.WriteLine("-------------------------------------------");
Console.WriteLine("El monto total es:"+Monto.ToString("0.00"));