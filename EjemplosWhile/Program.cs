namespace EjemplosWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int repetir = 100;
            int i = 100; //este es un contador

            //while
            //while (i < repetir)
            //{
            //    i++;
            //    Console.WriteLine("Bienvenido  i =" + i);
            //}

            //do-while
            do
            {
                i++; 
                Console.WriteLine("Bienvenido  i =" + i);

            } while (i < repetir);
            
            
        }
    }
}
