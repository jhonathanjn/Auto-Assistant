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

            string username = string.Empty;
            

            try
            {
                for (int i = 0; i < complement.Length; i++)
                {
                    string docs = $@"C:\Users\{Environment.UserName}\OneDrive\Documentos\{target + '.' + complement[i]}";
                    string img = $@"C:\Users\{Environment.UserName}\OneDrive\Pictures\{target + '.' + complement[i]}";
                    string area = $@"C:\Users\{Environment.UserName}\OneDrive\Desktop\{target + '.' + complement[i]}";



                    if (File.Exists(docs))
                    {
                        Console.WriteLine($"Abrindo {target}");

                        Process.Start(new ProcessStartInfo
                        {
                            FileName = docs,
                            UseShellExecute = true
                        });
                        return true;
                    }
                    else if (File.Exists(img))
                    {
                        Console.WriteLine($"Abrindo {target}");

                        Process.Start(new ProcessStartInfo
                        {
                            FileName = img,
                            UseShellExecute = true
                        });
                        return true;
                    }
                    else if (File.Exists(area))
                    {
                        Console.WriteLine($"Abrindo {target}");

                        Process.Start(new ProcessStartInfo
                        {
                            FileName = area,
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
