using ProjetoCelularPoo;
using ProjetoCelularPoo.Models;

Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia(numero:"93284-3294",modelo:"G11",imei:"12345",memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("YouTube");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone: ");
Smartphone iphone = new Iphone (numero:"93264-3432",modelo:"Iphone 13",imei:"54321",memoria: 128 );
iphone.Ligar();
iphone.InstalarAplicativo("X");