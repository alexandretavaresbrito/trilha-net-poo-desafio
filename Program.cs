using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone
Nokia tijolao = new Nokia("1234-5678", 128, "123456789", "G 21");

tijolao.Ligar();
tijolao.ReceberLigacao();
tijolao.InstalarAplicativo("Whatsapp");

Console.WriteLine("-------------------------------");

Iphone iphone = new Iphone("8765-4321", 64, "987654321", "15");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");