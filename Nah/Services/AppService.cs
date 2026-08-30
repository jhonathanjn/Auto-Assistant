using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel;


namespace Nah.Services
{
    internal class AppService
    {

        public bool OpenApp( string target)
        {
            try
            {
                Console.WriteLine($"Abrindo {target}");

                Process.Start(new ProcessStartInfo
                {
                    FileName = target,
                    UseShellExecute = true
                });
                return true;
            }
            catch (Win32Exception)
            {
                return false;
            }
                    
        }   
    }
}
