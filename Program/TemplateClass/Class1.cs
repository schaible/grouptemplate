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

        public string WordFind()
        {
            string word = "";
            int pos1 = text.IndexOf("{");
            int pos2 = text.IndexOf("}");
            word = text.Substring(pos1, (pos2 - pos1) + 1);

            return word;
        }

    }
}
