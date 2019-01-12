/*
https://www.hackerrank.com/challenges/grading/problem
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the gradingStudents function below.
     */
    static int[] gradingStudents(int[] grades, int n) {
        /*
         * Write your code here.
         */
        
        for (int i = 0; i < n; i++){
            if (grades[i] >= 38){
                if (grades[i] % 5 == 3){
                    grades[i] +=2 ;
                }
                else if (grades[i] % 5 == 4){
                    grades[i] += 1;
                }
            }
        }

        return grades;

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades,n);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}
