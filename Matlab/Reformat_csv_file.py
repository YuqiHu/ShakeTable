import csv

new_text = []
with open('Data\\2024\\GM1_Dis(cm).txt', newline='') as csvfile:
    spamreader = csv.reader(csvfile, delimiter=' ', quotechar='|')
    for row in spamreader:
        new_row = '{' + ', '.join(row) + '},'
        new_text.append(new_row)

with open('Data\\2024\\GM1_Dis(cm)_convert.txt', 'w', newline='') as csvfile:
    for row in new_text:
        csvfile.write("%s\n" % row)


print("done")
