# Control-lcd-display
Printing text on LCD screen using C# forms and Arduino  


# Here is the arduino diagram



<img width="1596" height="520" alt="lcd" src="https://github.com/user-attachments/assets/d83e189a-ff3a-4913-8313-fd0e8dcf098e" />




# C# Form 
🖼️ C# Windows Forms Interface Below is an example of the Windows Forms interface. You can customize it however you like:

<img width="391" height="297" alt="C# Form" src="https://github.com/user-attachments/assets/b5efbeff-65f6-4e90-a583-96ed4d4ca2ce" />




# ⚙️ Prerequisites

🚨 Before running the project, make sure you’ve done the following:

🧩 Add the Serial Port Tool (SerialPort) to your form from the Visual Studio Toolbox.

🔌 Set the correct COM port for your Arduino.

📟 Upload the appropriate sketch to your Arduino board.









# 🛠️ Setup Instructions


1-🔧 Build the circuit using the diagram above.

2-💾 Upload the Arduino code using the Arduino IDE.

3-🛠️ Create a new Windows Forms App project in Visual Studio.

4-📦 Add SerialPort, TextBox, and Button controls from the Toolbox.

5-💻 Insert the provided C# code into your form.

6-🚀 Run the application and start sending text to your LCD!





# ❗️ Notes
🔍 If the LCD doesn't display text, try changing the I2C address from 0x27 to 0x3F.

🔒 If you get a "port access denied" error, make sure no other application is using the COM port.

📚 If needed, install the LiquidCrystal_I2C library via the Arduino Library Manager.
