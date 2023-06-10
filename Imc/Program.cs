Console.WriteLine("Entre com a medida da sua altura");
double altura = double.Parse(Console.ReadLine());
Console.WriteLine("Entre com a medida de peso");
double peso = double.Parse(Console.ReadLine());
double imc = peso / (altura * altura);

Console.WriteLine("Seu imc é " + imc);
Console.WriteLine();
if (imc < 16.9)
    Console.WriteLine("Muito abaixo do peso");
if ( imc < 17 && imc <18.4 )
    Console.WriteLine("Abaixo do peso");
else
    if (imc < 18.5 && imc < 24.9 )
    Console.WriteLine("peso normal");
else 
    if ( imc < 25 && imc < 29.9)
    Console.WriteLine("acima do peso");
else 
    if (imc < 30 && imc < 34.9)
    Console.WriteLine("obesidade de grau 1");
else
    if ( imc < 35 && imc < 40)
    Console.WriteLine("obesidade de grau 2");
else
    Console.WriteLine("obesidade de grau 3");







