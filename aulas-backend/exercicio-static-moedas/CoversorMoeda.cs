namespace exercicio_static_moedas
{
    public static class CoversorMoeda
    {
        public static float Resultado { get; set; }  
        public static float valor { get; set; }
        public static float RealParaDolar(float valor)
        {
            Console.WriteLine($"Digite o valor em real que deseja converter para dólar:");
            valor = float.Parse(Console.ReadLine()!);

            return valor / 4.99f;
        }
        public static float DolarParaReal(float valor)
        {
            Console.WriteLine($"Digite o valor em dólar que deseja converter para real:");
            valor = float.Parse(Console.ReadLine()!);

            return valor / 0.20f;
        }
    }
}