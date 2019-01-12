/*
*Complete the getSecondLargest function in the editor below. 
*It has one parameter: an array,nums , of n numbers. 
*The function must find and return the second largest number in nums.
*
*https://www.hackerrank.com/challenges/js10-arrays/problem
*/

'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });
    
    main();    
});

function readLine() {
    return inputString[currentLine++];
}

/**
*   Return the second largest number in the array.
*   @param {Number[]} nums - An array of numbers.
*   @return {Number} The second largest number in the array.
**/
function getSecondLargest(nums) {
    // Complete the function
    var maxnum = 0;
    var nexmax = 0;

    for (var i = 0; i < nums.length; i++){
        if (nums[i] > maxnum) {
            nexmax = maxnum;
            maxnum = nums[i];
        }
        if (nums[i] > nexmax && nums[i] < maxnum) {
            nexmax = nums[i];
        }
    }
    return nexmax;
}


function main() {
    const n = +(readLine());
    const nums = readLine().split(' ').map(Number);
    
    console.log(getSecondLargest(nums));
}