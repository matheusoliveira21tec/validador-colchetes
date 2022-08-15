// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

string colchetes = "()()()()";

List<char> chars = new List<char>();
chars.AddRange(colchetes);
int cont = 0;
if (chars.Count() % 2 != 0 && chars.Count() != 0)
{
    Console.WriteLine("Invalido");
    Environment.Exit(0);
}

while (cont < chars.Count)
{
    if (
        (chars[cont] == '[' || chars[cont] == '{' || chars[cont] == '(')
        && (chars[cont + 1] != '}' && chars[cont + 1] != ')' && chars[cont + 1] != ']')
    )
    {
        cont++;
    }
    else
    {
        if (chars.Count() >= 2)
        {
            if (chars[cont] == '[' && chars[cont + 1] == ']')
            {
                chars.RemoveRange(cont, 2);
            }
        }
        if (chars.Count() >= 2)
        {
            if (chars[cont] == '{' && chars[cont + 1] == '}')
            {
                chars.RemoveRange(cont, 2);
            }
        }
        if (chars.Count() >= 2)
        {
            if (chars[cont] == '(' && chars[cont + 1] == ')')
            {
                chars.RemoveRange(cont, 2);
            }
        }
        if (chars.Count() >= 2)
        {
            if (
                (chars[cont] == '(' && chars[cont + 1] != ')')
                || (chars[cont] == '[' && chars[cont + 1] != ']')
                || (chars[cont] == '{' && chars[cont + 1] != '}')
            )
            {
                Console.WriteLine("Invalido");
                Environment.Exit(0);
            }
        }
        if (chars.Count() >= 2)
        {
            if (chars[cont] == ')' || chars[cont] == ']' || chars[cont] == '}')
            {
                Console.WriteLine("Invalido");
                Environment.Exit(0);
            }
        }
        cont = 0;
    }
    if (cont + 1 == chars.Count())
    {
        cont = chars.Count();
    }
}
;

if (chars.Count() > 0)
{
    Console.WriteLine("Invalido");
}
else
{
    Console.WriteLine("Valido");
}
