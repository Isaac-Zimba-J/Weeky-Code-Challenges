import numpy
def mean(lst):
    ans = sum(lst)
    total = len(lst)
    print(ans/total)

def stddeviation(num):

    ans = numpy.std(num)
    print(ans)

lst = []

number = int(input("How many numbers do you have : "))

i = 0


while i < number:
    item = int(input('Enter value number now : '))
    lst.append(item)
    i+=1


print("Mean : ", mean(lst))
print("Standard Deviation :", stddeviation(lst))