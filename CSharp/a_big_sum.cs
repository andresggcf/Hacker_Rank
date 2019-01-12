/*Calculate and print the sum of the elements in an array, 
keeping in mind that some of those integers may be quite large.

https://www.hackerrank.com/challenges/a-very-big-sum/problem

*/

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

    // Complete the aVeryBigSum function below.
    static long aVeryBigSum(long[] ar, int arLen) {
        long res = 0;
        for (int i = 0; i < arLen; i++){
            res += ar[i];
        }

        return res;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
        ;
        long result = aVeryBigSum(ar,arCount);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
