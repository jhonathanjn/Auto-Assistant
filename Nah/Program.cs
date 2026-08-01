using Nah.Models;

namespace Program
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("===========================================================================");
            Console.WriteLine("                               Version: 1.1                                ");
            Console.WriteLine("          =====           =====     ==========     =====     =====         ");
            Console.WriteLine("         =====--         =====     ===== =====     =====     =====         ");
            Console.WriteLine("        ===== ---       =====     =====  =====     =====     =====         ");
            Console.WriteLine("       =====   ---     =====     =====   =====     ===============         ");
            Console.WriteLine("      =====     ---   =====     ==============     ===============         ");
            Console.WriteLine("     =====       --- =====     =====     =====     =====     =====         ");
            Console.WriteLine("    =====           =====     =====      =====     =====     =====         ");
            Console.WriteLine("===========================================================================");


            while (true)
            {

                Console.Write("Nah > ");

                string? command = Console.ReadLine();


                if (string.IsNullOrWhiteSpace(command))
                    continue;


                if (command == "sair")
                {
                    Console.WriteLine("Exiting Nah...");
                    break;
                }

                if(command == "clear")
                {
                    Console.Clear();
                    Console.WriteLine("===========================================================================");
                    Console.WriteLine("                               Version: 1.1                                ");
                    Console.WriteLine("          =====           =====     ==========     =====     =====         ");
                    Console.WriteLine("         =====--         =====     ===== =====     =====     =====         ");
                    Console.WriteLine("        ===== ---       =====     =====  =====     =====     =====         ");
                    Console.WriteLine("       =====   ---     =====     =====   =====     ===============         ");
                    Console.WriteLine("      =====     ---   =====     ==============     ===============         ");
                    Console.WriteLine("     =====       --- =====     =====     =====     =====     =====         ");
                    Console.WriteLine("    =====           =====     =====      =====     =====     =====         ");
                    Console.WriteLine("===========================================================================");
                    continue;
                }

                if (command == "ajuda" || command == "help")
                {
                    Helpme help = new Helpme();

                    help.Help();

                    continue;
                }
                
                Console.WriteLine($"Comando '{command}' não encontrado");

                
                
            }
        }
    }
}