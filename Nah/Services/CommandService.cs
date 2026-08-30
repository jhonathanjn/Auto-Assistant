using Nah.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Nah.Services
{
    internal class CommandService
    {
        public void ConsoleCommand(string target)
        {       
            AppService appService = new AppService();
            FileService fileService = new FileService();
            FolderService folderService = new FolderService();

            if (fileService.OpenFile(target))
            {
                return;
            }
            else if (folderService.OpenFolder(target))
            {
                return;
            }
            else if (appService.OpenApp(target))
            {
                return;
            }
            else
            {
                Console.WriteLine(target + " is not a valid command.");
            }


        }
    }
}
