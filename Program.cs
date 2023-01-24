using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "(19)98741-5847", modelo: "Nokia 5.4", imei: "9998887774154", memoria: 4);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "(19)95874-2233", modelo: "Iphone 13 Pro", imei: "3332221114455", memoria: 6);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Console.ReadKey();