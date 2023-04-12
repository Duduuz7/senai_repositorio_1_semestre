// BomDia();
// BoaTarde();

// Console.WriteLine(BoaNoite());

// string batatinha = BoaNoite();
// Console.WriteLine(batatinha);



// static void BomDia(){
//     Console.WriteLine($"Bom dia!");
// }

// static void BoaTarde(){
//     Console.WriteLine($"Boa Tarde!");
// }

// static string BoaNoite(){
//     return "Boa Noite!";    
// } 




// Criar um método para somar dois números



// static float Soma(float n1, float n2){
//     float r = n1 + n2;
//     return r;
// }

// float batatinha = Soma(16, 123);

// Console.WriteLine($"Resultado: {batatinha}");



// criar método para multiplicar 2 números


static float mult(float n1, float n2){

   return (n1 * n2);
}

Console.WriteLine($"Digite o primeiro número: ");
float n1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o segundo número: ");
float n2 = float.Parse(Console.ReadLine()!);

Console.WriteLine(@$"
O resultado da multiplicação é: {mult(n1,n2)}
");





// criar método para dividir 2 números

// static float div(float n1, float n2){

//    return (n1 * n2);
// }

// Console.WriteLine($"Digite o primeiro número: ");
// float n1 = float.Parse(Console.ReadLine()!);

// Console.WriteLine($"Digite o segundo número: ");
// float n2 = float.Parse(Console.ReadLine()!);

// Console.WriteLine(@$"
// O resultado da multiplicação é: {div(n1,n2)}
// ");


// criar método para subtrair 2 números

// static float sub(float n1, float n2){

//    return (n1 * n2);
// }

// Console.WriteLine($"Digite o primeiro número: ");
// float n1 = float.Parse(Console.ReadLine()!);

// Console.WriteLine($"Digite o segundo número: ");
// float n2 = float.Parse(Console.ReadLine()!);

// Console.WriteLine(@$"
// O resultado da multiplicação é: {sub(n1,n2)}
// ");