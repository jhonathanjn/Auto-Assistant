using Nah.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Nah.Services
{
    internal class CommandService
    {
        public void ConsoleCommand(Command command)
        {       
            AppService appService = new AppService();
            FileService fileService = new FileService();
            FolderService folderService = new FolderService();

            if(command.Target != string.Empty)
            {

                if (fileService.OpenFile(command.Target))
                {
                    return;
                }
                else if (folderService.OpenFolder(command.Target))
                {
                    return;
                }
                else if (appService.OpenApp(command.Target))
                {
                    return;
                }
                else
                {
                    Console.WriteLine(command.Target + " is not a valid command.");
                }
            }
            else
            {
                Console.WriteLine("Como posso ajudar?");
            }


        }
    }
}
