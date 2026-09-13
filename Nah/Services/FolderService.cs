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
                string docs = $@"C:\Users\{Environment.UserName}\OneDrive\Documentos\{target}";
                string img = $@"C:\Users\{Environment.UserName}\OneDrive\Pictures\{target}";
                string area = $@"C:\Users\{Environment.UserName}\OneDrive\Desktop\{target}";
                if (Directory.Exists(docs))
                {

                    Console.WriteLine($"Abrindo Pasta {target}");

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "explorer.exe",
                        Arguments = docs,
                        UseShellExecute = true
                    });
                    return true;
                }
                else if (Directory.Exists(img))
                {
                    Console.WriteLine($"Abrindo {target}");

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = img,
                        UseShellExecute = true
                    });
                    return true;
                }
                else if (Directory.Exists(area))
                {
                    Console.WriteLine($"Abrindo {target}");

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = area,
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
