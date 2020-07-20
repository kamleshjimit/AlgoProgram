using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

public class StringAlgos
{
    public static bool check_parentheses(string data)
    {
        Stack<Char> parenthesesStack = new Stack<Char>();
        List<Char> openingBrackets = new List<Char> { '{', '[', '(' };
        List<Char> closingBrakcets = new List<Char> { '}', ']', ')' };

        foreach (char c in data)
        {
            if (openingBrackets.Contains(c))
            {
                parenthesesStack.Push(c);
            }
            else if (closingBrakcets.Contains(c))
            {
                if (parenthesesStack.Count > 0)
                {
                    char pop = parenthesesStack.Pop();
                    Console.WriteLine(c + " " + pop);

                    if (IsParentesisMatch(pop, c))
                        continue;
                    else
                        return false;
                }
            }
            else
            {
                continue;
            }
        }

        if (parenthesesStack.Count == 0)
            return true;
        else
            return false;
    }

    private static bool IsParentesisMatch(char c1, char c2)
    {
        //Console.WriteLine(c1 + " " + c2);
        if (c1 == '{' && c2 == '}')
            return true;
        else if (c1 == '[' && c2 == ']')
            return true;
        else if (c1 == '(' && c2 == ')')
            return true;

        return false;
    }


    public static int longestUniqueSubstring(string input)
    {
        int maxlength = 0;
        //int[] lastIndex = new int[256];
        int[] lastIndex = Enumerable.Repeat(-1, 256).ToArray();
        int i = 0;

        for (int j = 0; j < input.Length; j++)
        {
            i = Math.Max(i, lastIndex[input[j]] + 1);
            maxlength = Math.Max(maxlength, j - i + 1);

            lastIndex[input[j]] = j;
        }

        return maxlength;
    }


}
