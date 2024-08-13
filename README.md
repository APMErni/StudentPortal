# Student Portal

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)

## Introduction
The **Student Portal** is a web application that allows users to create, read, update, and delete records of students. The application is designed to be responsive and works well on different devices.

## Features
- Create new student records
- Read existing student records
- Update student records
- Delete student records
- Responsive UI for various devices

## Technologies Used
- ASP .Net Core MVC
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

## Installation
To get a local copy up and running, follow these steps:

1. **Clone the repository:**
    ```bash
    git clone [https://github.com/your-username/student-portal.git](https://github.com/APMErni/StudentPortal.git)
    cd student-portal
    ```

2. **Install .NET 8.0:**
    Make sure you have .NET 8.0 installed on your machine. You can download it from the [official .NET website](https://dotnet.microsoft.com/download).

3. **Install NuGet packages:**
    Restore the required NuGet packages by running:
    ```bash
    dotnet restore
    ```

4. **Run the application:**
    ```bash
    dotnet run
    ```

## Usage
Once the application is running, you can access it via your web browser at `http://localhost:5000` (or the port specified in your configuration).

### Example Usage

1. **Create a new student record:**
   - Navigate to the "Add Student" page by clicking on the "Add Student" button.
   - Fill in the required details (Name, Email, Phone, Program) and submit the form.

2. **Read student records:**
   - Navigate to the "All Students" page to view all student records.

3. **Update a student record:**
   - Click on the "Edit" button next to a student record.
   - Modify the details and submit the form.

4. **Delete a student record:**
   - Click on the "Delete" button next to a student record.
   - Confirm the deletion.

## Contributing
Contributions are welcome! Please follow these steps to contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature-name`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/your-feature-name`).
5. Open a pull request.
