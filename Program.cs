// Cebolinha trocar o L por R (Frase Cebolinha = frase com Dislalia)

String Frase;
String FraseCebolinha;

Console.Write("Digite uma frase: ");
Frase = Console.ReadLine()!;
Console.WriteLine();

FraseCebolinha = Frase

.Replace ("r", "l")
.Replace("R","L");

Console.WriteLine($"Frase com Dislalia: {FraseCebolinha}");