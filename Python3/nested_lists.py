# Given the names and grades for each student in a Physics class of 
#N students, store them in a nested list and print the name(s) of any 
#student(s) having the second lowest grade.

#Note: If there are multiple students with the same grade, order their 
#names alphabetically and print each name on a new line.

#https://www.hackerrank.com/challenges/nested-list/problem

if __name__ == '__main__':
    students = []
    secondw = []
    minn = 100
    secondminn = 100
    for _ in range(int(input())):
        student=[]
        name = input()
        score = float(input())
        student.append(name)
        student.append(score)
        students.append(student)
        if (score < minn):
            secondminn = minn
            minn = score
        if (score > minn and score < secondminn):
            secondminn = score
    for i in range(len(students)):
        if (students[i][1] == secondminn):
            secondw.append(students[i][0])
    #sorted list
    sseconw = sorted(secondw)
    for x in range (len(sseconw)):
        print(sseconw[x])
