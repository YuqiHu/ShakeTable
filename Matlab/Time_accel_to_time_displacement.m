% Input name of file here
name = "Data\2024\GM1_Acc(g).txt";

% Open text file
fileID = fopen(name,'r');
formatSpec = '%f\t%f\n';
sizeA = [2 Inf];

% Experimental conversion
% Find displacement form acceleration
Accel = fscanf(fileID,formatSpec, sizeA);
accel_data = Accel(2,:).';
time_data = Accel(1,:).';
% dt = time_data(5)-time_data(4);
% disp_data = acc2disp(accel_data,dt);
% 
% % Save displacement data
% name_w = split(name,"_");
% fileID_w = fopen(name_w(1) + "_Dis(m).txt", "w");
% Disp = cat(2,time_data, disp_data);
% writematrix(Disp,name_w(1) + "_Dis(m).txt");
% fclose(fileID);
% fclose(fileID_w);

% [Tc,Xc,Ac,Xu,Au] = q_scale(t,a,xmax)
%    t = array of time at equal sampling intervals (s) 
%    a = array of acceleration record that matches "t" above (g) 
%    xmax = maximum amplitude of motion (cm) 
%    Do NOT exceed the limits of the table with xmax! 
% 
%    Tc = Scaled command time array (s)
%    Xc = Scaled table position command array (cm) 
%    Ac = Acceleration array, found by differentiating Xc twice (g) 
%    Tu = Earthquake time array (s)
%    Xu = Computed earthquake displacement (not scaled) (cm) 
%    Au = Earthquake acceleration array (g) 

[Tc, Xc, Ac, Tu, Xu, Au] = q_scale(time_data, accel_data, 4);

% Plot the figures
figure
plot(Tc, Xc, Tc, Ac)

% Save displacement data
name_w = split(name,"_");
fileID_w = fopen(name_w(1) + "_Dis(cm).txt", "w");
Disp = cat(2,Tc, Xc);
writematrix(Disp,name_w(1) + "_Dis(cm).txt");
fclose(fileID);
fclose(fileID_w);
