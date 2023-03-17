

def SortList(val):

    mixList = [1,9,2,8,3,7,4,6,5,8,3,99,74,12,54,8,79,35]
    
    choice = val.lower()

    if choice == "asc":
        mixList.sort()
        print('Your list in ascending order is : ',mixList)
    elif choice == "desc":
        mixList.sort()
        mixList.reverse()
        print('Your list in descending order is : ', mixList)
    elif choice == "none":
        print('Your list as it was given : ',mixList)
    else:
        print("What you chose does not exist")


while True:
    print("\n\nThank you for trying this code, please \n\nfollow and like for more such content and suggestions are welsome")
    choice = str(input("\n\nEnter either '\a asc','\a desc' or '\a none' \nto get a list in ascending, descending or none : "))
    SortList(choice)