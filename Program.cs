// Exemplos de uso do Try Catch




// Ao tentar executar o código, será apontado o erro.
// int[] numeros = {1,2,3};
// int indice = 5;
// int elemetno = 5;
// int elemento = numeros[indice];
// Console.WriteLine("Elemento" + elemento);



try
{
    int[] numeros = { 1, 2, 3 };
    int indice = 5;
    int elemento = numeros[indice];
    Console.WriteLine("Elemento: " + elemento);
}
catch (IndexOutOfRangeException error)
{
    Console.WriteLine($"O motivo do erro é: {error}");
}



//A clássica divisão por 0

// int n1 = 10;

// int n2 = 0;

// int divisao = n1/n2;


// Console.WriteLine($"A divisão é: {divisao}");



try
{
    int n1 = 10;
    int n2 = 0;
    int divisao = n1/n2;
    Console.WriteLine($"A divisã é: {divisao}");
}
catch(DivideByZeroException errorr)
{
    Console.WriteLine("Erro: divisão por zero não é permitida");
}



