﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateClassNameSpace;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            TemplateClass trial = new TemplateClass("my name is {name} my age is {age}");
            trial.WordFind();
            Console.WriteLine(trial.WordFind());
            Console.ReadLine();
        }
    }
}
