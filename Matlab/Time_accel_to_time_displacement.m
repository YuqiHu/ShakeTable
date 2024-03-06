% Input name of file here
name = "GM1_Acc(g).txt";

% Open text file
fileID = fopen('GM1_Acc(g).txt','r');
formatSpec = '%f\t%f';
sizeA = [2 Inf];

% Find displacement form acceleration
Accel = fscanf(fileID,formatSpec, sizeA);
accel_data = Accel(2,:).';
time_data = Accel(1,:).';
dt = time_data(5)-time_data(4);
disp_data = acc2disp(accel_data,dt);

figure
plot(time_data, accel_data)
title("Time-Acceleration Data")
figure
plot(time_data, disp_data)
title("Time-Displacement Data")