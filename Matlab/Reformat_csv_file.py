import csv

new_text = []
with open('Data\\2024\\Sine_Sweep_displacement.txt', newline='') as csvfile:
    spamreader = csv.reader(csvfile, delimiter=' ', quotechar='|')
    for row in spamreader:
        new_row = float(row[0])/10
        new_text.append(new_row)

i = 0
j = 0
max_line = 8000
while i < len(new_text):
    name = 'Data\\2024\\Sine_Sweep_displacement_convert_' + str(i) + '.txt'
    with open(name, 'w', newline='') as csvfile:
        while j < max_line and i < len(new_text):
            csvfile.write("\t%f,\n" % new_text[i])
            j = j + 1
            i = i + 1
    j = 0

print("done")
