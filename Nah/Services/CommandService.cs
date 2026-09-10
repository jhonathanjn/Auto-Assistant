using Nah.Models;

namespace Nah.Services
{
    internal class CommandService
    {
        public void ConsoleCommand(string[] values)
        {
            AppService appService = new AppService();
            FileService fileService = new FileService();
            FolderService folderService = new FolderService();

            if (values[0] == "abrir" || values[0] == "open")
            {
                if (values.Length < 2)
                {
                    Console.WriteLine("Digite o que deseja abrir.");
                    return;
                }

                if (fileService.OpenFile(values[1]))
                {
                    return;
                }
                else if (folderService.OpenFolder(values[1]))
                {
                    return;
                }
                else if (appService.OpenApp(values[1]))
                {
                    return;
                }
                else
                {
                    Console.WriteLine(values[1] + " não é um arquivo, pasta ou aplicativo válido.");
                }
            }
            else if (values[0].ToLower() == "nah" && values.Length == 1)
            {
                Console.WriteLine("Como posso ajudar?");
                return;
            }
            else if (values[0].ToLower() == "nah")
            {

                if (values[1].ToLower() == "new" || values[1].ToLower() == "n")
                {
                    if (values.Length < 3)
                    {
                        Console.WriteLine("Digite o tipo de dado que deseja adicionar.");
                        return;
                    }

                    if (values[2].ToLower() == "command" || values[2].ToLower() == "c")
                    {
                        if (values.Length < 4)
                        {
                            Console.WriteLine("Digite o nome do comando.");
                            return;
                        }

                        Console.WriteLine("Adding command: " + values[3]);
                    }
                    else
                    {
                        Console.WriteLine($"Tipo '{values[2]}' não reconhecido.");
                    }
                }
                else
                {
                    Console.WriteLine($"Operação '{values[1]}' não reconhecida.");
                }
            }
           

            else
            {
                Console.WriteLine($"Comando '{values[0]}' não reconhecido.");
            }
        }
    }
}