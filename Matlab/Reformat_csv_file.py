import csv

new_text = []
with open('Data\\2024\\GM1_Dis(cm).txt', newline='') as csvfile:
    spamreader = csv.reader(csvfile, delimiter=' ', quotechar='|')
    counter = 0
    for row in spamreader:
        if counter ==51:
            print(row)

        counter+=1


print("done")
