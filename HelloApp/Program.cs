//Imprime um texto na tela.
using System.Security.AccessControl;

Console.WriteLine("Hello World!");

Console.WriteLine("Seja bem vindo ao meu primeiro programa!");

// Criação das Variaveis.
string nome;
int idade;
decimal peso;

// Linha de código.
Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual é a sua idade?");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é o seu peso?");
peso = decimal.Parse(Console.ReadLine());

Console.WriteLine("Olá " + nome + " tudo bem? Você tem " + idade + " anos e você pesa " + peso + " kg.");