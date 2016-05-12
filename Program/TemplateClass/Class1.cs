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
        public string replacement = "";
        public string word = "";

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
            word = "";
            int pos1 = text.IndexOf("{");
            int pos2 = text.IndexOf("}");
            word = text.Substring(pos1, (pos2 - pos1) + 1);
            Get_Replacement();
            text = text.Replace(word, replacement);
            
            return text;
        }

        public string Get_Replacement()
        {
            Console.WriteLine("what would you like to replace " + word +" with?" );
            replacement = Console.ReadLine();

            return replacement;

        }




    }
}
