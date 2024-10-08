﻿// See https://aka.ms/new-console-template for more information

//Aluna: Iolanda Carvalho.

//Console.WriteLine("Hello, World!");

return1:
Console.Write("Por favor, informe o seu peso (kg): ");
if (!decimal.TryParse(Console.ReadLine(), out decimal peso))
{
    Console.WriteLine("\n------------------");
    Console.WriteLine("- Valor Inválido -");
    Console.WriteLine("------------------\n");
    goto return1;
}
else
{
    return2:
    Console.Write("Agora informe sua altura (m): ");
    if (!decimal.TryParse(Console.ReadLine(), out decimal altura))
    {
        Console.WriteLine("\n------------------");
        Console.WriteLine("- Valor Inválido -");
        Console.WriteLine("------------------\n");
        goto return2;
    }
    else
    {
        decimal imc = Math.Round((peso / (altura*altura)), 2);
        Console.WriteLine("\nVocê possui algum dos problemas listados abaixo? ");
        Console.WriteLine("1 - Diabetes \n2 - Problemas nas articulações (Ex.:artrite) \n3 - Problemas cardíacos \n4 - Obesidade \n5 - Dores nas costas \n6 - Ansiedade ou estresse");
        return3:
        Console.Write("\n(Responda a pergunta com sim ou não): ");
        string soun = Console.ReadLine().ToLower();
        if (soun == "sim")
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine($"Seu IMC é: {imc}");
            Console.WriteLine("---------------------\n");
            Console.WriteLine("Gostaria de dar algumas dicas dos exercícios mais indicados para dada tipo de problema citado acima. Espero que ajude.\n");
            Console.WriteLine("1. DIABETES \n- Sugestões de exercícios: \n• Caminhadas rápidas \n• Natação \n• Treinamento de resistência (com pesos leves a moderados) \n• Exercícios aeróbicos de baixa intensidade \n• Yoga (ajuda no controle do estresse e glicemia\n");
            Console.WriteLine("2. PROBLEMAS NAS ARTICULAÇÕES (Ex.: artrite) \n- Sugestões de exercícios: \n• Hidroginástica \n• Caminhadas leves \n• Ciclismo (com baixa resistência) \n• Alongamentos e yoga \n• Pilates (fortalecimento sem sobrecarga articular)\n");
            Console.WriteLine("3. PROBLEMAS CARDÍACOS \n- Sugestões de exercícios: \n• Caminhadas moderadas \n• Bicicleta leve \n• Natação \n• Exercícios de alongamento \n• Tai Chi (uma forma de exercício suave que também ajuda com equilíbrio\n");
            Console.WriteLine("4. OBESIDADE \n- Sugestões de exercícios: \n• Caminhadas leves e caminhadas rápidas \n• Natação \n• Exercícios em bicicleta ergométrica \n• Exercícios aeróbicos de baixo impacto \n• Hidroginástica\n");
            Console.WriteLine("5. DORES NAS COSTAS \n- Sugestões de exercícios: \n• Caminhada em ritmo leve \n• Natação ou hidroginástica \n• Yoga com foco em alongamento e fortalecimento do núcleo \n• Pilates (fortalecimento do núcleo) \n• Exercícios de alongamento e mobilidade\n");
            Console.WriteLine("6. ANSIEDADE OU ESTRESSE \n- Sugestões de exercícios: \n•Yoga \n• Tai Chi \n• Meditação guiada (combinada com alongamentos) \n• Caminhadas ao ar livre \n• Dança (para liberar endorfina)\n");
        }
        else if (soun == "não" || soun == "nao")
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine($"Seu IMC é: {imc}");
            Console.WriteLine("---------------------\n");
            Console.WriteLine("- Continue sempre cuidando da saúde fazendo exercícios regulares. -");
        }
        else
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine("- Resposta Inválida -");
            Console.WriteLine("---------------------");
            goto return3;
        }
    }
}
