﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Древние греки придумали Олимпийские игры, пока вели одну из своих " +
                "нескончаемых войн.";

            Type type = typeof(String);

            MethodInfo substr = type.GetMethod("Substring",
                new Type[] { typeof(int), typeof(int) });

            Object result = substr.Invoke(str, new Object[] { 0, 40 });
            Console.WriteLine("{0}\n\"{1}\".", substr, result);


            Type myType = typeof(List<int>);

            foreach(var info in myType.GetConstructors())
            {
                Console.WriteLine(info.ToString());
            }
        }
    }
}
/*2.	Получить список конструкторов класса List<T>*/
