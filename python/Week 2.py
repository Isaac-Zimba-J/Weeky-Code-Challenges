

myList = [1,3,7,-9,-3,7,8,9,3,5,]

def SumZero(lst):

    SmallValueOne = lst[0]
    BigValueTwo = lst[1]
    FinalPair = [(SmallValueOne, BigValueTwo)]

    for i in range (2, len(lst)):
        if abs(lst[i]) < abs(SmallValueOne):
            BigValueTwo = SmallValueOne
            SmallValueOne = lst[i]
            FinalPair = [(SmallValueOne, BigValueTwo)]

        elif abs(lst[i]) < abs(BigValueTwo):
            BigValueTwo = lst[i]
            FinalPair.append((SmallValueOne, BigValueTwo))

        return min(FinalPair, key=lambda pair: abs(pair[0] + pair[1]))
             
func = SumZero(myList)
print(func)
