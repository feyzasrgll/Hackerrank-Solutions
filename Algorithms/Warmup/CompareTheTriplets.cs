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

class Solution {

    static List<int> compareTriplets(List<int> a, List<int> b) {
        
        List<int> result = new List<int>();
        int Apoint = 0;
        int Bpoint = 0;
        int i = 0;
        for(i=0; i<3; i++)
        {
            if(a[i] != b[i])
            {
                if(a[i] < b[i])
                 Bpoint += 1;
                else
                 Apoint += 1;
            }            
        }
        result.Add(Apoint);
        result.Add(Bpoint);
        
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
