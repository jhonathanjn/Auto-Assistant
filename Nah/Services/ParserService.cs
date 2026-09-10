using Nah.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Nodes;
using System.Xml.Linq;

namespace Nah.Services
{
    internal class ParserService
    {
        public Command? Parser(string[] values)
        {
            string[] commands = { "abrir", "open", "nah" };
            string[] actions = { "new", "n", "remove", "r", "move", "m", "copy", "c", "update", "u" };
            string[] types = { "file", "f", "folder", "d"};

            Command command = new Command();


            if (!values.Any())
            {
                Console.WriteLine("Nenhum comando foi informado");
                return null;
            }

            if (!commands.Contains(values[0].ToLower()))
            {
                Console.WriteLine($"Comando '{values[0]}' não encontrado");
                return null;
            }

            // Comandos persolalizados

            if (!actions.Contains(values[1].ToLower()))
            {
                Console.WriteLine($"Ação '{values[1]}' não encontrada");
                return null;
            }

            if (!types.Contains(values[2].ToLower()))
            {
                Console.WriteLine($"Tipo '{values[2]}' não encontrado");
                return null;
            }

            command.Name = values[0].ToLower();
            command.Action = values[1].ToLower();
            command.Type = values[2].ToLower();
            command.Target = values[3].ToLower();

            return command;
        }
    }
}
