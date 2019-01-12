/*Given an array of integers, find the sum of its elements.

For example, if the array ar=[1,2,3], 1+2+3 = 6 , so return 6.

Function Description

Complete the simpleArraySum function in the editor below. It must return the sum of the array elements as an integer.

simpleArraySum has the following parameter(s):

ar: an array of integers
Input Format

The first line contains an integer, , denoting the size of the array. 
The second line contains  space-separated integers representing the array's elements.

Constraints
0<n, ar[i] <= 100

Output Format

Print the sum of the array's elements as a single integer.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the simpleArraySum function below.
     */
    static int simpleArraySum(int[] ar) {
        /*
         * Write your code here.
         */

         int len = ar.Length;
         int sum = 0;
         for (int i = 0; i < ar.Length ; i++){
             sum = sum + ar[i];
         }

         return sum;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = simpleArraySum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
