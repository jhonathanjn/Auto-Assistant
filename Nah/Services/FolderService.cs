using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace Nah.Services
{
    internal class FolderService
    {
        public bool OpenFolder(string target)
        {
            try
            {
                string caminho = $@"C:\Users\Jhonathan7\OneDrive\Documentos\{target}";
                if (Directory.Exists(caminho))
                {

                    Console.WriteLine($"Abrindo Pasta {target}");

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "explorer.exe",
                        Arguments = caminho,
                        UseShellExecute = true
                    });
                    return true;
                }
                
                return false;
            }
            catch (Win32Exception )
            {
                return false;
            }
        }
    }
}
