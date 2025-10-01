Student Management System
A C# Console Application that demonstrates practical usage of collections in .NET, including Dictionaries, HashSets, and Set Operations with real student data.

Features
📚 Task 1: Student Dictionary
Stores student ID and name pairs

Demonstrates dictionary operations:

Adding and retrieving students

Searching by ID

Uses actual student data with proper IDs

🔄 Task 3: Unique Course Codes
Implements HashSet for storing unique course codes

Automatically prevents duplicate entries

Shows basic set operations (Add, Remove, Contains)

📊 Task 4: Set Operations
Compares Math and Science class enrollments

Demonstrates essential set operations:

Intersection: Students in both classes

Difference: Students only in one class

Union: All unique students

Symmetric Difference: Students in exactly one class

Student Data
The application uses the following student records:

Student ID	Student Name
101	Lihlethando Funde
102	Thando Funde
103	Lihle Funde
104	Yemvelo Sonka
105	Thando Brown
Class Assignments
Math Class
Lihlethando Funde

Thando Funde

Lihle Funde

Yemvelo Sonka

Science Class
Thando Funde

Lihle Funde

Thando Brown

Yemvelo Sonka

Prerequisites
.NET 6.0 SDK or later

Visual Studio 2022 or Visual Studio Code

Basic understanding of C# programming

Installation
Clone or Download the Project

bash
git clone <repository-url>
cd StudentManagementSystem
Open in Visual Studio

Open StudentManagementSystem.sln in Visual Studio

Or create a new Console App and replace the contents of Program.cs

Build the Solution

Press Ctrl + Shift + B or use the Build menu

Ensure there are no compilation errors

Running the Application
In Visual Studio:

Press F5 to run with debugging

Or Ctrl + F5 to run without debugging

Using Command Line:

bash
dotnet run
Project Structure
text
StudentManagementSystem/
├── Program.cs                 # Main application file
├── StudentManagementSystem.csproj  # Project configuration
└── README.md                  # This file
Code Overview
Key Methods
DemonstrateDictionary(): Shows dictionary operations with student data

DemonstrateHashSet(): Demonstrates unique course code storage

DemonstrateSetOperations(): Performs set comparisons between classes

DisplaySet(): Helper method to display HashSet contents

Collections Used
Dictionary<int, string>

Key: Student ID (integer)

Value: Student Name (string)

HashSet<string>

Stores unique course codes

Demonstrates automatic duplicate handling

Set Operations

IntersectWith(): Finds common elements

ExceptWith(): Finds elements in first set only

UnionWith(): Combines all unique elements

SymmetricExceptWith(): Finds elements in exactly one set

Expected Output
The application will display:

Student Dictionary with all student records

Unique Course Codes showing automatic duplicate prevention

Set Operations Results comparing class enrollments

Enrollment Analysis with statistics and percentages

Learning Objectives
This project demonstrates:

✅ Dictionary creation, population, and retrieval

✅ HashSet for storing unique values

✅ Set operations (Union, Intersection, Difference)

✅ Collection iteration and display

✅ Real-world data structure applications

Customization
You can easily modify:

Student Data: Update the dictionary in DemonstrateDictionary()

Course Codes: Change the HashSet contents in DemonstrateHashSet()

Class Assignments: Modify the sets in DemonstrateSetOperations()

Troubleshooting
Common Issues
Build Errors: Ensure .NET 6.0+ SDK is installed

Runtime Errors: Check for null references in collection operations

Output Formatting: Adjust console output methods as needed

Dependencies
.NET 6.0 Runtime

System.Collections.Generic namespace

Contributing
Feel free to extend this project by:

Adding more collection types (List, Queue, Stack)

Implementing file I/O for student data

Adding GUI interface

Creating unit tests

License
This project is for educational purposes. Feel free to use and modify as needed.
