/*
Problem link: https://www.hackerrank.com/challenges/apple-and-orange/problem
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
    static void countApplesAndOranges(int s, int t, int a, int b, int m, int n, int[] apples, int[] oranges) {
        int applesCount = 0;
        int orangesCount = 0;

        //apples
        for(int i = 0; i < m; i++){
            apples[i]+=a;
            if(apples[i]>=s && apples[i]<=t){
                applesCount+=1;
            }
        }

        //oranges
        for(int i = 0; i < n; i++){
            oranges[i]+=b;
            if(oranges[i]>=s && oranges[i]<=t){
                orangesCount+=1;
            }
        }
        Console.WriteLine(applesCount);
        Console.WriteLine(orangesCount);
    }

    static void Main(string[] args) {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]);

        int t = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]);

        int b = Convert.ToInt32(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
        ;

        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
        ;
        countApplesAndOranges(s, t, a, b, m, n, apples, oranges);
    }
}
