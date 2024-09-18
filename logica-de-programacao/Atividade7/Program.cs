// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
using System.Linq.Expressions;

Console.WriteLine ("\n----------------------------------");
Console.WriteLine ("- DECLARAÇÃO DE IMPOSTO DE RENDA -");
Console.WriteLine ("----------------------------------");

float imposto;
return1:
Console.Write ("\nInforme o valor do salário bruto: ");
if (float.TryParse (Console.ReadLine(), out float salario)) {
    if (salario <= 3000) {
        imposto = salario / 100 * 10;
        Console.WriteLine ($"\nNesse caso, esse é o valor do imposto de renda: {imposto:F2}\n");
    }
    else if (salario <= 6000) {
        imposto = salario / 100 * 15;
        Console.WriteLine ($"\nNesse caso, esse é o valor do imposto de renda: {imposto:F2}\n");
    }
    else {
        imposto = salario / 100 * 20;
        Console.WriteLine ($"\nNesse caso, esse é o valor do imposto de renda: {imposto:F2}\n");
    }
}
else {
    Console.WriteLine ("\nValor inválido.\n");
    goto return1;
}