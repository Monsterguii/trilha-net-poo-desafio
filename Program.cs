using System.ComponentModel;
using DesafioPOO.Models;

// Implementado!!

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "723245", modelo: "Modelo 2", imei: " 2222222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");