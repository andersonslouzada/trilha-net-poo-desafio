using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("123456789", "Iphone 12", "123456789", 128);
Console.WriteLine("Iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n-------------------\n");

Nokia nokia = new Nokia("987654321", "Nokia 3310", "987654321", 32);
Console.WriteLine("Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");