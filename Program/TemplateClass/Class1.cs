using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateClassNameSpace
{
    public class TemplateClass
    {
        public string text = "";

        public TemplateClass(string input)
        {
           text = input;
        }

        public string WordSwap()
        {
            text = text.Replace("Hi", "See");
            return text;
        }


    }
}
