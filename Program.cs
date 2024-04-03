using DesafioPOO.Models;

var nokia = new Nokia("119843718347", "Tijolo", "245432523452345", 64);

var iphone = new Iphone("11948395738", "15 Pro", "2342352353452345", 256);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsapp");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("instagram");