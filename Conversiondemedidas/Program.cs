// See https://aka.ms/new-console-template for more information
Console.WriteLine("**SISTEMA DE MEDIDAS");
Console.WriteLine("");

double metros,centimetros,yardas,pies,pulgadas;
Console.WriteLine("Ingrese los metros");
metros= double.Parse(Console.ReadLine());
centimetros = metros * 100;
pulgadas = centimetros / 2.54;
pies = pulgadas / 12;
yardas = pies / 3;

Console.WriteLine("Las diferenetes medidas de metros son:");
Console.WriteLine("Centimetros:"+centimetros.ToString("0.00"));
Console.WriteLine("pulgadas:"+pulgadas.ToString("0.00"));
Console.WriteLine("pies:"+pies.ToString("0.00"));
Console.WriteLine("yardas"+yardas.ToString("0.00"));
