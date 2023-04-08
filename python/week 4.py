
#get the string you want from the user 
sentence = str(input("Enter sentence : "))


def reverse_word(val):

    # split the sentence by the spaces after the word
    words =  val.split(" ")
    strings = []

    for i in words:
        strings.insert(0, i)

    print(" ".join(strings))

reverse_word(sentence)
