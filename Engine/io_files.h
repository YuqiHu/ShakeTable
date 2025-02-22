#pragma once
#include <fstream>
#include <iostream>
#include <string>
#include <vector>

using namespace std;

void readFile(const string& filename, vector<vector<double>>& data, int linetoskip);
void fileOutput(const string& outputFilename, const vector<vector<double>>& data);