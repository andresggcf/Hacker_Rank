## Given the participants' score sheet for your University Sports Day, 
## you are required to find the runner-up score. You are given  scores. Store 
## them in a list and find the score of the runner-up.
##
## https://www.hackerrank.com/challenges/find-second-maximum-number-in-a-list/problem
##

if __name__ == '__main__':
    n = int(input())
    arr = list(map(int, input().split()))

    winner=-99999999999;
    runnerup=-9999999999;

    for i in range(n):
        if (arr[i] > winner):
            runnerup = winner
            winner = arr[i]
        if (arr[i] > runnerup and arr[i] < winner):
            runnerup = arr[i]
    print(runnerup)