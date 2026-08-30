using Nah.Models;
using Nah.Services;

namespace Program
{
    class Program
    {
        static void Main(string[] args) {

            Show show = new Show();

            CommandService service = new CommandService();


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

                if(values[0] == "clear")
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

                if (values[0] == "abrir" && values.Length > 1)
                {
                    service.ConsoleCommand(values[1]);
                }
                else if (values[0] == "abrir")
                {
                    Console.WriteLine("Digite o caminho do arquivo ou pasta que deseja abrir!");
                }
                         
            }
        }
    }
}