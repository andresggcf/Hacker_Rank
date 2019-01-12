/*Alice and Bob each created one problem for HackerRank. A reviewer rates the 
two challenges, awarding points on a scale from 1 to 100 for three categories: 
problem clarity, originality, and difficulty.

We define the rating for Alice's challenge to be the triplet a=(a[0], a[1], a[2]), 
and the rating for Bob's challenge to be the triplet b=(b[0], b[1], b[2]).

Your task is to find their comparison points by comparing a[0] with b[0], a[1] 
with b[1], and a[2] with b[2] .

If a[i] > b[i], then Alice is awarded  point.
If a[i] < b[i], then Bob is awarded  point.
If a[i] = b[i], then neither person receives a point.
Comparison points is the total points a person earned.

Given a and b, determine their respective comparison points.

Function Description

It must return an array of two integers, the first being Alice's score and the 
second being Bob's.

Constraints

Output Format
Return an array of two integers denoting the respective comparison points earned by Alice and Bob.*/

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

    // Complete the compareTriplets function below.
    static List<int> compareTriplets(List<int> a, List<int> b) {
        int pointa = 0;
        int pointb = 0;
        List<int> res = new List<int>();
        for (int i=0 ; i<3; i++){
            if (a[i] == b[i]){
                pointa += 0;
                pointb += 0;
            }
            else if (a[i] < b[i])
                pointb += 1;
            else if (a[i] > b[i])
                pointa += 1;
        }
        //Console.WriteLine(pointa +" / " + pointb);
        res.Add(pointa);
        res.Add(pointb);
        return res;
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
