// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

Console.Clear();

Console.WriteLine ("\n------------------------");
Console.WriteLine ("- CONVERSÃO DE MEDIDAS -");
Console.WriteLine ("------------------------\n");

Console.Write ("Digite a distância em metros: ");
string distanciaS = Console.ReadLine();
float distancia = float.Parse (distanciaS);

Console.Write ("\nEscolha a unidade de conversão (cm, km, mi): ");
string unidade = Console.ReadLine();

float result;
switch (unidade) {
    case "cm":
        result = distancia * 100;
        Console.WriteLine ("\n------------------------");
        Console.WriteLine ($"Resultado: {result:F2}cm");
        Console.WriteLine ($"\n{distancia}m = {result:F2}cm");
        Console.WriteLine ("------------------------\n");
        break;
    case "km":
        result = distancia / 1000;
        Console.WriteLine ("\n\n------------------------");
        Console.WriteLine ($"Resultado: {result:F2}km");
        Console.WriteLine ($"\n{distancia}m = {result:F2}km");
        Console.WriteLine ("------------------------\n");
        break;
    case "mi":
        result = distancia / 1609;
        Console.WriteLine ("\n\n------------------------");
        Console.WriteLine ($"Resultado: {result:F7}mi");
        Console.WriteLine ($"\n{distancia}m = {result:F7}mi");
        Console.WriteLine ("------------------------\n");
        break;
    default:
        Console.WriteLine ("Valor inválido.");
        break;
}