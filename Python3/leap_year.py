## You are given the year, and you have to write a function to check if the
## year is leap or not.

## https://www.hackerrank.com/challenges/write-a-function/problem


def is_leap(year):
    leap = False
    
    # Write your logic here
    if (year % 4 == 0 and (year % 400 == 0 or year % 100 != 0)):
        leap = True
    
    return leap