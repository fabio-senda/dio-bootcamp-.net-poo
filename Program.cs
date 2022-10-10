using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia: ");
Smartphone nokia = new Nokia(numero: "12345-6789", modelo: "5.4", imei: "111222333", memoria: 64);
nokia.Ligar();
nokia.ListarAplicativosInstalados();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\nIphone: ");
Smartphone iphone = new Iphone(numero: "12345-6789", modelo: "X", imei: "111222333", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
iphone.InstalarAplicativo("Facebook");
iphone.ListarAplicativosInstalados();
