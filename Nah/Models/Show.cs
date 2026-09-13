using System;
using System.Collections.Generic;
using System.Text;

namespace Nah.Models
{
    internal class Show
    {

        public void ShowVersion()
        {
            Console.WriteLine("===========================================================================");
            Console.WriteLine("                               Version: 0.3.0                                ");
            Console.WriteLine("          =====           =====     ==========     =====     =====         ");
            Console.WriteLine("         =====--         =====     ===== =====     =====     =====         ");
            Console.WriteLine("        ===== ---       =====     =====  =====     =====     =====         ");
            Console.WriteLine("       =====   ---     =====     =====   =====     ===============         ");
            Console.WriteLine("      =====     ---   =====     ==============     ===============         ");
            Console.WriteLine("     =====       --- =====     =====     =====     =====     =====         ");
            Console.WriteLine("    =====           =====     =====      =====     =====     =====         ");
            Console.WriteLine("===========================================================================");
        }

        public void Help()
        {

            Console.WriteLine("\tComandos disponíveis:");
            Console.WriteLine("\t - sair");
            Console.WriteLine("\t - clear/cl - limpar console");
            Console.WriteLine("\t - ajuda/help");
        }

        public string ErrorCommand(string command)
        {
            return $"Comando '{command}' não encontrado";
        }

       


    }
}
