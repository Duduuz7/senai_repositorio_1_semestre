// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// // VARIAVEIS CONSTANTES

// // Declarando uma variavel
// //tipo nome = valor
// string name = "Eduardo";

// const int age = 17;
// Console.WriteLine("A idade do " + name + " e  " + age + " anos");


// TIPOS DE DADOS

// int quantidade = 10;
// double preco = 4.99D;
// float altura = 1.80f;
// bool careca = true;
// string texto = "Ola, mundo";
// char letra = 'C'

// OPERADOR DE ATRIBUICAO

// int idade = 36;


// // OPERADORES ARITMETICOS

// // soma

// Console.WriteLine(4 + 4);

// // subtracao

// Console.WriteLine(10 - 8);

// // multiplicacao

// Console.WriteLine(5 * 9);

// // divisao

// Console.WriteLine(10 / 2);

// // modular 

// Console.WriteLine(5 % 2);


// OPERADORES DE COMPARACAO 

// igual a

// Console.WriteLine(5 == 6);


// // maior ou igual a

// Console.WriteLine(5 >= 4);


// // menor ou igual a

// Console.WriteLine(4 <= 4);

// // maior que

// Console.WriteLine(5 > 1);

// // menor que

// Console.WriteLine(5 < 2);

// // diferente de

// Console.WriteLine(5 != 8);


// OPERADORES LOGICOS E TABELA VERDADE 

// && : e
// || : ou
// ! : negacao

                                      // TABELA VERDADE

// Console.WriteLine(5 == 5 && 8 == 8); //TRUE && TRUE = TRUE

// Console.WriteLine(5 == 5 && 8 == 9); //TRUE && FALSE = FALSE

// Console.WriteLine(5 == 6 && 8 == 8); //FAlSE && TRUE = FALSE

// Console.WriteLine(5 == 6 && 8 == 9); //FALSE && FALSE = FALSE


// Console.WriteLine(2 == 2 || 3 == 3); //TRUE || TRUE = TRUE

// Console.WriteLine(2 == 2 || 3 == 4); //TRUE || FALSE = TRUE

// Console.WriteLine(2 == 3 || 3 == 3); //FALSE || TRUE = TRUE

// Console.WriteLine(1 == 2 || 3 == 5); //FALSE || FALSE = FALSE


// Console.WriteLine(!(2 == 2 || 3 == 8));  


// Crie um programa para calcular o IMC de uma pessoa

// ENTRADAS 

string nome = "Eduardo";
float peso = 51.9f;
float altura = 1.80f;

// PROCESSAMENTO

float imc = peso / (altura * altura);

Console.WriteLine($"O IMC do " + nome + "  e de : " + Math.Round(imc,2));
