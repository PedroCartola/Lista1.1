string? valor;
double[] salario = new double[10];
double cont = 0;

//Declarar os salários
for(int i=0; i<10; i++)
{
    do
    {
        Console.WriteLine("Digite o " + (i + 1) + "º salário: ");
        valor = Console.ReadLine();
        Double.TryParse(valor, out salario[i]);
    }while (salario[i] < 0);
}

//Definir o maior salário
for(int j=0; j<10; j++)
{
    if (salario[j] > cont)
    {
        cont = salario[j];
    }
}

Console.WriteLine("Maior salário é: " + cont);