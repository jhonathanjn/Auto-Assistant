using System;
using System.Collections.Generic;
using System.Text;

namespace Nah.Models
{
    internal class Command
    {
        public string Name { get; set; }
        public string Action { get; set; }
        public string Type { get; set; }
        public string  Target { get; set; } = string.Empty;

    }
}
