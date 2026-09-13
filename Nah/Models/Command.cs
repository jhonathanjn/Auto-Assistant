using System;
using System.Collections.Generic;
using System.Text;

namespace Nah.Models
{
    internal class Command
    {
        public string Name { get; set; } = string.Empty;
        public string Action { get; set; } = string.Empty;
        public string Target { get; set; } = string.Empty;

        public Command() { }


        public Command(string[] values)
        {
            if (values.Length == 1)
            {
                Name = values[0];
            }
            if (values.Length == 2)
            {
                Name = values[0];
                Target = values[1];
            }
            if (values.Length >= 3)
            {
                Name = values[0];
                Action = values[1];
                Target = values[2];
            }

        }
    }
}
