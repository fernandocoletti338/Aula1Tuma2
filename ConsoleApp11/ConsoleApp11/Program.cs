using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        //iniciando uma constante
        const int testeConst = 999;
        
        static void Main(string[] args)
        {
            string testePrimitivo = string.Empty;
            String outroTestePrimitivo = string.Empty;
            bool testComp = "123" == "123";
            Boolean testeComp = "123" == "123";

            var testeFora = string.Empty;
            testeFora = "teste";

            var teste1 = "string"; //texto
            var teste2 = 'A'; // char
            var teste3 = 8; //int
            var teste4 = 3.8; //double
            var teste5 = 0x0F; //hex
            //apresentando a const
            Console.WriteLine(testeConst);
            Console.ReadKey();
            

        }
    }
}
