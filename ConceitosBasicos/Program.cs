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




