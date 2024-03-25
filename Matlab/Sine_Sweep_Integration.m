% Input name of file here
name = "Data\2024\Sweep Acceleration.txt";

% Open text file
fileID = fopen(name,'r');
%formatSpec = '%f\t%f\n';
formatSpec = '%f\n';
sizeA = [1 Inf];

% Experimental conversion
% Find displacement form acceleration
Accel = fscanf(fileID,formatSpec, sizeA);
accel_data = Accel(1,:).';

