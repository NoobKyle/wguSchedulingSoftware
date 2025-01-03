# **Windows Forms Application with MySQL Database Integration**

## **Overview**
This application is designed to manage customer records and appointments. It includes user authentication, multi-language support, time zone adjustments, appointment scheduling, and reporting. The application uses a MySQL database for data storage and logs user activities for auditing purposes.

---

## **System Requirements**
### **Hardware**
- Processor: Intel i3 or equivalent
- RAM: 4GB or more
- Storage: 500MB free space

### **Software**
- Windows 10/11
- Visual Studio 2022 (or later)
- .NET Framework 4.7.2 (or later)
- MySQL Server 8.0 (or later)
- MySQL Connector/NET (for ADO.NET)

---

## **Database Schema**
### **Tables**
1. **Users**
   - Stores user credentials for authentication.
   - Fields: UserID, Username, PasswordHash.

2. **Customers**
   - Stores customer information.
   - Fields: CustomerID, Name, Address, PhoneNumber.

3. **Appointments**
   - Stores appointment details.
   - Fields: AppointmentID, CustomerID, AppointmentType, StartTime, EndTime.

---

## **Features and Functionality**

### **1. Login Form**
- **Determine User Location:** The application detects the user’s location using their IP address.
- **Multi-language Support:** Login and error messages are translated into English and one additional language (e.g., Spanish).
- **Authentication:** Verifies username and password against the database using hashed credentials.

### **2. Customer Records**
- **Add, Update, and Delete Customers:** Users can manage customer records with validations for each operation.
- **Validation Requirements:**
  - All fields (Name, Address, Phone Number) must be non-empty and trimmed.
  - Phone numbers must allow only digits and dashes.
- **Exception Handling:** Ensures robust error management during add, update, and delete operations.

### **3. Appointments**
- **Schedule, Update, and Delete Appointments:** Users can manage appointments linked to specific customers.
- **Validation Requirements:**
  - Appointments must be scheduled during business hours (9:00 AM - 5:00 PM, Monday to Friday, EST).
  - Prevents overlapping appointments for the same customer.
- **Exception Handling:** Handles errors during appointment operations.

### **4. Calendar View**
- Provides a calendar interface for selecting dates.
- Displays appointments for a selected day.

### **5. Time Zone Adjustments**
- Automatically adjusts appointment times based on the user’s time zone and daylight saving time.

### **6. Appointment Alerts**
- Generates alerts for users who log in within 15 minutes of an upcoming appointment.

### **7. Reports**
- **Report Types:**
  1. Number of appointment types by month.
  2. Schedule for each user.
  3. One additional customizable report.
- **Implementation:** Uses collection classes and lambda expressions for generating reports.

### **8. Login History**
- Logs the timestamp and username of each login in a text file named `Login_History.txt`.
- Appends each new record to the log file for auditing purposes.

---

## **Usage Instructions**
1. **Set Up the Database:**
   - Install MySQL Server and create the required tables using the provided schema.
   - Configure database credentials in the application settings.

2. **Run the Application:**
   - Open the solution in Visual Studio.
   - Build and run the project.

3. **Using the Features:**
   - Log in using valid credentials.
   - Navigate through the customer and appointment management features using the provided interface.
   - Use the calendar view to manage and view appointments.
   - Generate reports as needed from the reporting section.

4. **Log File:**
   - Check `Login_History.txt` for login activity logs.

---

## **Error Handling**
- Provides detailed error messages for database and input validation issues.
- Ensures smooth user experience by handling unexpected exceptions gracefully.

---

## **Security Recommendations**
- Use secure password hashing algorithms (e.g., BCrypt or SHA256).
- Use parameterized queries to prevent SQL injection.
- Avoid hardcoding sensitive information such as database credentials; use environment variables or secure configuration management tools.

---

## **Future Enhancements**
- Add role-based access control for different user types.
- Implement additional localization for more languages.
- Extend reporting capabilities with graphical data visualizations.

---

This document provides an overview of the application's functionality, setup, and usage. For further assistance, refer to the application's source code.
