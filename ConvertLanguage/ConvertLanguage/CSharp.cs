﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertLanguage
{
    public class CSharp
    {
        private string result;
        public string Result { get => result; set => result = value; }
        public CSharp()
        {
            result += "using System\n" +
                  "namespace FormalSpecification\n{\n" +
                  "\tpublic class Program\n\t{\n\t\tx:R\n\t}\n}";
        }
      

        
    }
}
