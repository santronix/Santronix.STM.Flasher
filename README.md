# Santronix.STM.Flasher
STM Flasher is a open source tool for methodically flashing the STM32 based controllers using USB to TTL

Here's the easiest tool to flash your STM32 based controller using USB-TTL converter. The user interface is very easy to follow.
**Follow the below process to use the tool**

<img width="1141" height="701" alt="Screenshot 2025-09-01 at 10 32 53 PM" src="https://github.com/user-attachments/assets/55ee11dd-f6da-4518-bc99-d6fdd3d41df7" />

**Step 1 : Select the Testplan**
The testplan based approach is very easy to follow and help you add as many test commands as you need in a structured XML file. The XML file has simple structure as below

<img width="760" height="360" alt="Screenshot 2025-09-01 at 10 36 44 PM" src="https://github.com/user-attachments/assets/a82ea403-1409-41c8-976e-bb1dbb185ec2" />

Testplan is a main node which has an array of TestActivity. Each of the TestActivity element represent a single test. The TestActivity has Id, Name and Command. The Id has to be a unique number and usually serial numbers from 1 to n can be used. The name is a name of the activity. The command has specific commands to be executed. The command may/may not have variable parameters which are represented in braces for e.g., {selectedPort}, {flashFile}, they need to be typed exactly as it is. The selectedPort is the USB port detected as COM on computer where the DUT is connected and flashFile is the complete path of the flashfile. The value of these parameters is passed from the Utility.

**Step 2: Select the Flashfile**
The flashfile in the form of .bin can be browsed and selected

**Step 3: Select DUT port**
The DUT port is the COM port selected on the utility.

**Step 4: Loop**
If you wish to execute the testplan once, just deselect the "Loop Enabled". To execute the testplan in loop for e.g., 100 times, just select "Loop Enabled" and enter the number of loops to be exeucted. When loops are exeucted, the total number of loops, Passed and failed are updated after each loop execution.

_The Log windows displayes the Log in real time and can be exported by "Export" button and can be cleared using "clear Log" button_

The cycle time and Total execution time is also displayed on the top right corner in HH:MM:SS

The below screenshot displays the entire flashing status on Single UI screen

<img width="1510" height="771" alt="Screenshot 2025-09-02 at 5 15 23 PM" src="https://github.com/user-attachments/assets/06e93dad-aa2f-441f-b539-898590ef69e9" />

