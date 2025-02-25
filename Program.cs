using System.Security.Cryptography.X509Certificates;

namespace Methods_4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ascii_art();
            Console.WriteLine();
            Console.WriteLine();
            ascii2();
            Console.WriteLine();
            Console.WriteLine();
            ascii_dolphin();
            Console.WriteLine();
            Console.WriteLine();
            knock();
        }

        public static void ascii_art()

        {
            Console.WriteLine("  /\\                 /\\");
            Console.WriteLine(" / \\'._    (\\_/)   _.'/ \\");
            Console.WriteLine(" /_.''._'--('.')--'_.''._\\");
            Console.WriteLine(" | \\_ / `;=/ \" \\=;` \\ _/ |");
            Console.WriteLine(" \\/ `\\__|` \\___/`|__/`  \\/");
            Console.WriteLine("          \\(/|\\)/");
            Console.WriteLine("           \" ` \"               ");

          
        }
         public static void ascii2()
        {
            Console.WriteLine("  /\\_/\\");
            Console.WriteLine(" ( o.o )");
            Console.WriteLine("  > ^ <");
            
        }
        
        public static void ascii_dolphin()
        {
            Console.WriteLine("        ,");
            Console.WriteLine("     __)\\_");
            Console.WriteLine("(\\_.-'    a`-.");
            Console.WriteLine("(/~~````(/~^^`");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void knock()
        {
            Console.WriteLine("Knock Knock....");
            Thread.Sleep(500);
            Console.ReadLine();
            Console.WriteLine("Who's there?");
            Thread.Sleep(500);
            Console.ReadLine();
            Console.WriteLine("water");
            Thread.Sleep(500);
            Console.ReadLine();
            Console.WriteLine("water who");
            Thread.Sleep(500);
           
            Console.ReadLine();
            Console.WriteLine("WATER YOU DOING TODAY");
           

        }
        



    }
}
