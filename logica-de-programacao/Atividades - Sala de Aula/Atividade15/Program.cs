// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

Console.Clear();
Console.Write("Informe uma letra: ");
char letra = char.Parse(Console.ReadLine().ToLower());

if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u') {
    Console.WriteLine($"A letra '{letra}' é uma vogal!");
}
else {
    Console.WriteLine($"A letra '{letra}' é uma consoante!");
}