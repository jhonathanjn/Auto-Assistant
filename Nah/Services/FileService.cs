using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace Nah.Services
{
    internal class FileService
    {

        public bool OpenFile(string target)
        {
            string[] complement = { "pdf", "jpg", "png", "mp3", "mp4"};
            

            try
            {
                for (int i = 0; i < complement.Length; i++)
                {
                    string caminho = $@"C:\Users\Jhonathan7\OneDrive\Documentos\{target + '.' + complement[i]}";

                    if(File.Exists(caminho))
                    {
                        Console.WriteLine($"Abrindo {target}");

                        Process.Start(new ProcessStartInfo
                        {
                            FileName = caminho,
                            UseShellExecute = true
                        });
                        return true;
                    }
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
