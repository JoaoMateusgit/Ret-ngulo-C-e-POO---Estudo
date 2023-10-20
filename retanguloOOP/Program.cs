
using retanguloOOP;
using System.Globalization;
namespace course
{
    class retanguloOOP
    {
        static void Main(String[] args)
        {
             Class1 a = new Class1();

            Console.WriteLine("entre a altura do Retângulo: ", CultureInfo.InvariantCulture);
            a.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("entre a largura do Retângulo: ", CultureInfo.InvariantCulture);
            a.largura = double.Parse(Console.ReadLine());
            
    

            Console.WriteLine("A área do seu retângulo é: " + a);
        }
    }
}
