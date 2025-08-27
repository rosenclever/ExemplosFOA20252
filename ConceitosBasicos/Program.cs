/*
byte idade;
string nome;
Console.Write("Digite seu nome: ");
nome = Console.ReadLine();
Console.Write("Digite sua idade: ");
idade = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Olá " + nome + ". A idade informada foi {0}", idade);// idade = 20
idade *= 2; // idade = idade * 2 
Console.WriteLine($"A nova idade é {idade++}"); //40
Console.WriteLine($"A nova idade é {++idade}"); //42


//altere o programa para que solicite ao usuário informar o seu salário e ao final informe o desconto de IRPF de acordo com o salário informado. Utilize a tabela oficial de descontos de IRPF do Brasil.
try
{
    decimal salario, irpfDevido;
    Console.Write("Informe o salário: ");
    salario = decimal.Parse(Console.ReadLine());

    if (salario <= 2428.8m)
        irpfDevido = 0;
    else if (salario <= 2826.65m)
        irpfDevido = salario * 0.075m - 182.16m;
    else if (salario <= 3751.05m)
        irpfDevido = salario * 0.15m - 394.16m;
    else if (salario <= 4664.68m)
        irpfDevido = salario * 0.225m - 675.49m;
    else
        irpfDevido = salario * 0.275m - 908.73m;

    Console.WriteLine($"Para o salario {salario:C2} o IRPF a ser pago é {irpfDevido:C2}");
}
catch (FormatException)
{
    Console.WriteLine("Digite apenas valores numéricos");
}
catch(Exception e)
{
    Console.WriteLine("Ocorreu um erro. Entre em contato com o suporte técnico.");
    Console.WriteLine(e.ToString());
}
*/

using ConceitosBasicos.uteis;

int opcao;
do
{
    Console.WriteLine("[0] Sair");
    Console.WriteLine("[1] Somar dois números");
    Console.WriteLine("[2] Converter metros em milímetros");
    Console.WriteLine("[3] Calcular Aumento");
    Console.Write("Escolha a opção desejada: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            break;
        case 1:
            SomaDoisNumeros somaDoisNumeros = new SomaDoisNumeros();
            int result;
            Console.Write("Informe o primeiro valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o segundo valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            result = somaDoisNumeros.Somar(valor1, valor2);
            Console.WriteLine("A soma dos número {0} e {1} é {2}", valor1, valor2, result);
            break;
        case 2:
            Console.Write("Informe o valor em metros: ");
            double metros = Convert.ToDouble(Console.ReadLine());
            double milimetros = MetrosMilimetros.Converter(1.8);
            Console.WriteLine($"{metros}m corresponde a {milimetros}mm");
            break;
        case 3:
            CalculaAumento calculaAumento = new CalculaAumento();
            Console.Write("Informe o salário: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Informe o percentual de aumento: ");
            float percentual = float.Parse(Console.ReadLine());
            decimal valorAumento = calculaAumento.Calcular(salario, percentual);
            Console.WriteLine($"Para o salário {salario:c2}, dado o percentual {percentual}, o valor do aumento será de {valorAumento} resultando no novo salário de {(salario + valorAumento):c2}");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
} while (opcao != 0);







