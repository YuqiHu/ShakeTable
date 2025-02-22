# ShakeTable
This is the 2023-2024 multidisciplinary capstone project 13 at the University of Toronto. This is the code to run the University of Toronto Seismic Design Team shake table.

# 1. Pre-Processing

The Seismic Design Competition typically provides time-acceleration data for time-history analysis. However, the shake table requires time-displacement data, as the motor can only determine the number of steps or angles it needs to turn, not the speed or acceleration at which it should turn. To address this, the pre-processing module offers users a method to convert time-acceleration data into time-displacement data.

1. Open the ShakeTable.exe. By default, it is at the Pre-processing panel.
    
    ![image](https://github.com/user-attachments/assets/dcc0eb37-7e99-4f04-bb50-c98e3a7144df)

    

1. Choose the Unit of Acceleration in the dropdown menu. The available units are “g” and “m/s^2”
    
    ![image](https://github.com/user-attachments/assets/b29ff23f-682f-48d0-8725-416a482b8b6c)

    

1. Choose Delimiter in the dropdown menu. The available delimiters are “\t” (tab), “,” and “;”. If it doesn’t fit the data format, please use Excel to process it.
    
    ![image](https://github.com/user-attachments/assets/f0008799-66e6-4c06-bee4-2db1144c656b)

1. Choose the number of header lines to skip. The first line should be the first line of numerical data with 2 columns, time and acceleration. 
    
    For example, the first line of 2025 Ground Motion 1 is the time-acceleration data, 0 header line needs to be skipped.
    
   ![image](https://github.com/user-attachments/assets/0c3b784d-5e13-486a-95c4-ae4a18f35dea)    

1. Import the time acceleration data to the program.
    
    ![image](https://github.com/user-attachments/assets/52b3325e-5ee2-4b80-a86d-d3c3a684f9de)

    
1. Time acceleration data will show in the data grid below the “Import” button. The time acceleration plot will show on the right.
    
    ![image](https://github.com/user-attachments/assets/2f775bdc-d5d5-4b67-9d1c-34a47ee543fa)

1. Click the “Convert to Time-Displacement” button to convert time-acceleration data to time-displacement data. It may take a while to convert. Small drifting may exist in the final conversion. The time-displacement data will show in the data grid below the “Convert to Time-Displacement button” and the time-displacement graph will plot on the right.
    
    ![image](https://github.com/user-attachments/assets/d9008658-d048-4b76-84bd-6cbc835401a2)


1. Click the “Export” button to export the time-displacement file for running the shake table.
    
    ![image](https://github.com/user-attachments/assets/64c4fce6-92c6-458e-8776-8a2b28bb325f)


1. If the data is exported successfully, an information box will jump to the screen. Click OK. Time-acceleration to time-displacement data is converted and saved successfully.
    
    ![image](https://github.com/user-attachments/assets/ce0792f9-4d5c-4ef7-99c9-250330b63b25)

    

Validation:
* 2022 GM2 time-displacement data from UofT EERI

    ![image](https://github.com/user-attachments/assets/965ca094-2b0e-46ce-95c3-e12c2c66d92b)


* 2022 GM2 time-displacement data from the shake table program

    ![image](https://github.com/user-attachments/assets/f6d4e54e-479c-4e29-b52e-dba0501d7b24)

# 2. Shake Table Operation

**!!!!WARNINGS!!!!**
1. Make sure you run every shake test WITHOUT load at least once before you run the shake test.
2. The table should start at the middle of the axis. There is only 6 cm per side space for running the shake test. Running Ground Motion 2 may be close to the boundary of the shake table.
3. The current shake table DOES NOT HAVE AN EMERGENCY STOP BUTTON. Please run it with Grace’s instructions carefully and prevent any potential hazards.
4. Nobody except the operator should be near the control computer and wires.
5. When the shake test run with the load, such as the tower, please have at least 2 people stand outside the danger zone but close enough to catch the tower if the tower collapses.
_____________________________________________________________________________________________________________________________________________________________________________________________

1. Turn on the power and connect Arduino to the laptop.
2. Choose the “Table Control” tab at the top.
    
    ![image](https://github.com/user-attachments/assets/bfa21761-1561-4ec8-ab98-ff58dce3ef34)

1. Choose the COM PORT. It needs a bit of trial and error unless you know exactly which one you are using. If you choose the wrong one, the error message box will jump out. Just click OK and try another one.

    ![image](https://github.com/user-attachments/assets/0e6e34d1-89e7-44c0-bbf1-3899a3c0814b)

1. You can choose either Past GMs to run or import a time-displacement file. Some common ground motions are saved with the program.

    ![image](https://github.com/user-attachments/assets/5c5c3ed3-e28b-4235-8e0e-c37e4bc5c494)

1. Choose the time-displacement data converted from Pre-processing.

    ![image](https://github.com/user-attachments/assets/b7ba1003-b77f-4105-b180-b9b01cdc8d02)

1. Click the “Start” button

    ![image](https://github.com/user-attachments/assets/b302fc64-8f5c-45a0-8cd1-6dafbdeb444b)


# 3. Post-Processing

## 3.1 Response Spectrum Analysis

1. Choose the “Post-processing” tab.
    
    ![image](https://github.com/user-attachments/assets/69425db1-149b-4337-9ed8-4871e28980a7)

1. Import the time acceleration data.
2. Enter the maximum target period (maximum value of the x-axis). The tower period should be under 0.30 seconds in most of cases.
    
    ![image](https://github.com/user-attachments/assets/6f14f02c-fafb-4858-8c37-9588ee97a107)


1. Enter the period step (How fine/accurate you want the graph to be).
2. Enter the target tower damping ratio. The classic assumption of the damping ratio is 5%, but in many cases, our tower damping ratio is 2%-3%. It can be higher, but usually not as high as 5%.
    
    ![image](https://github.com/user-attachments/assets/b2cfe1cb-7a87-49a5-9a40-a64df33d47b5)
    
3. Do not change Beta and Gamma values unless you know what you are doing. The program used Newmark’s time-stepping method for integration. Typical selection for gamma is 1/2 and 1/6 ≤ beta ≤ 1/4.
    
    
    |  | Constant Average Acceleration | Linear Variation of Acceleration |
    | --- | --- | --- |
    | Beta | 1/4 = 0.25 | 1/6 = 0.16667 |
    | Gamma | 1/2 = 0.50 | 1/2 = 0.50 |
4. Choose the type of response spectrum you want to analyze.
    
    ![image](https://github.com/user-attachments/assets/30c62462-c8dc-4a0e-b37a-4e1b51cbb0bd)
 

1. Click the “Calculate Response Spectrum” button to plot the graph.
    
    ![image](https://github.com/user-attachments/assets/d814ca50-1add-4304-8f0c-e8686c8622dc)

    
2. Click the “Export” button to export the response spectrum.

Validation 

* Compare the results from the program with the result from Seismo Signals

  ![image](https://github.com/user-attachments/assets/6a7c0975-0599-46f4-84c3-5de9a0f98b70)


## 3.2 Non-uniform Fast Fourier Transform

I don’t want to write it again in C# from scratch so see the MATLAB code.















