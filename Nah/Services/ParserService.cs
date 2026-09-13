using Nah.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nah.Services
{
    internal class ParserService
    {
        public Command? Parser(string[] values)
        {

            string[] names = {"nah", "abrir", "open"};
            string[] actions = { "new", "n", "nf", "remove", "r", "move", "m", "copy", "c", "update", "u" };

            Command command = new Command(values);


            if (!values.Any())
            {
                Console.WriteLine("Nenhum comando informado!");
            }


            if(values.Length == 1)
            {

                if (!names.Contains(command.Name.ToLower()))
                {
                    Console.WriteLine("Comando não encontrado!");
                }
                
            }else if (values.Length == 2)
            {
                if (!names.Contains(command.Name.ToLower()))
                {
                    Console.WriteLine("Comando não encontrado!");

                }
                if (command.Target.ToLower() == string.Empty)
                {
                    Console.WriteLine("Alvo não encontrado!");
                }

            }else if (values.Length >= 3)
            {
                if (!names.Contains(command.Name.ToLower()))
                {
                    Console.WriteLine("Comando não encontrado!");

                }
                if (!actions.Contains(command.Action.ToLower()))
                {
                    Console.WriteLine("Ação invalida!");
                }
                if(command.Target.ToLower() == string.Empty){
                    Console.WriteLine("Alvo não encontrado!");
                }
            }


            return command;
        }
    }
}
