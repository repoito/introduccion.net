// See https://aka.ms/new-console-template for more information
Console.WriteLine("** CALCULADORA DE CAPITAL**");
Console.WriteLine("");

double monto1, monto2, monto3;
double capital,pm1,pm2,pm3,cp;

Console.WriteLine("Ingrese el monto 1:");
monto1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el monto 2:");
monto2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el monto 3:");
monto3 = double.Parse(Console.ReadLine());

capital = monto1 + monto2 + monto3;

pm1 = (monto1) / capital;
pm2 = (monto2) / capital;
pm3 = (monto3) / capital;

Console.WriteLine("El capital por hermano es:");
Console.WriteLine("Hermano 1:"+pm1.ToString("0.00%"));
Console.WriteLine("Hermano 2:"+pm2.ToString("0.00%"));
Console.WriteLine("Hermano 3:"+pm3.ToString("0.00%"));
