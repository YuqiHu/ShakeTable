accel_name = "Data\2021\GM2.csv";
disp_name = "Data\2021\2022_GM2.txt";
accel_data = readmatrix(accel_name);
time = (1:size(accel_data)).'.*0.001;

disp_data = readmatrix(disp_name);
disp_cal = acc2disp(accel_data.*9.81,0.001);

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

[Tc, Xc, Ac, Tu, Xu, Au] = q_scale((1:size(accel_data)).'.*0.001, accel_data, 3);
% Plot the figures
figure
plot(Tc, Ac, Tc, Xc)
title("Time-Acceleration Data")
figure
plot(Tu, Au, Tu,Xu)
legend("calculated","reference")
title("Time-Displacement Data")