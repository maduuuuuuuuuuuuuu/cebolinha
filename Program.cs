string frase;
string flase;
Console.WriteLine("digite uma flase pala mim");
frase = Console.ReadLine()!;
flase = frase
.Replace("R", "L")
.Replace("r", "l");
Console.WriteLine("");
Console.WriteLine(flase);

