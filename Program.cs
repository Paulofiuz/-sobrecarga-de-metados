

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Adicao();

            Console.WriteLine(calc.Somar(1, 2, 3));
            Console.WriteLine(calc.Somar(1, 2));
        }
    }

    public class Adicao
    {
        // Método para somar dois inteiros
        public int Somar(int x, int y)
        {
            return x + y;
        }

        // Sobrecarga: método para somar três inteiros
        public int Somar(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}