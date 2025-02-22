#include "pch.h"
#include "io_files.h"


void readFile(const string& filename, vector<vector<double>>& data, int linetoskip)
{
	// Try to open the user defined file
	ifstream file(filename);

	// If the file is not able to open, then output the error messages
	if (!file)
	{
		cerr << "Not able to open the file: " << filename << endl;
		return;
	}

	// skip the header lines as specified
	for (int i = 0; i < linetoskip; ++i)
	{
		string line;
		getline(file, line);
	}

	// read the values after the skipped lines
	double value;
	while (file >> value)
	{
		data.push_back({ value });
		while (file.peek() == '\t')
		{
			file.ignore();
			file >> value;
			data.back().push_back(value);
		}
	}

	file.close();
}


void fileOutput(const string& outputFilename, const vector<vector<double>>& data)
{
	// Create the output file
	ofstream outFile(outputFilename);

	// If the output file does not work, report the error
	if (!outFile.is_open())
	{
		cerr << "Error opening file: " << outputFilename << endl;
		return;
	}

	// Write data into the output file
	for (const auto& row : data)
	{
		for (const auto& value : row)
		{
			outFile << value << "\t";
		}
		outFile << endl;
	}

	// close the output file
	outFile.close();
}



//int main()
//{
//	vector<vector<double>> data;
//	int linetoskip;
//
//	cout << "Enter the number of lines to skip: ";
//	cin >> linetoskip;
//
//	readFile("GM1_2022_acc.txt", data, linetoskip);
//
//	for (const auto& row : data)
//	{
//		for (const auto& value : row)
//		{
//			cout << value << "\t";
//		}
//		cout << endl;
//	}
//
//	return 0;
//}