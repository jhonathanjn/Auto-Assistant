using Nah.Models;
using Nah.Services;

namespace Program
{
    class Program
    {
        static void Main(string[] args) {

            Show show = new Show();

            CommandService service = new CommandService();
            ParserService parser = new ParserService();


            show.ShowVersion();

            while (true)
            {
                Console.Write("Nah > ");

                string? result = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(result)) { 
                    Console.WriteLine("Digite um comando valido!");
                    continue;
                }

                string[] stringIgnore = { " ", "," };
                string[] values = result.Split(stringIgnore, StringSplitOptions.RemoveEmptyEntries);


                if (values[0] == "sair")
                {
                    Console.WriteLine("Exiting Nah...");
                    break;
                }

                if(values[0] == "clear" || values[0] == "cl")
                {
                    Console.Clear();
                    show.ShowVersion();
                    continue;
                }

                if (values[0] == "ajuda" || values[0] == "help")
                {
                    show.Help();
                    continue;
                }

                Command? command = parser.Parser(values);

                if (command != null)
                {
                    service.ConsoleCommand(command);
                }
            
                         
            }
        }
    }
}