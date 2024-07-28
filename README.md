# Calculator Web App in Blazor Server
__Images Will Be Added Soon!__
*  __This is a refined version of my [SWE 3643 Calculator Project](https://github.com/DiegoFraR/SWE3643-Calculator-WebApp). The code was cleaned up and unnecessary files were removed. The code was also refactored for a more polished look.__ 
* This application is a Web-Based Calculator in C# using Blazor Server. Unit Tests and End-To-End (E2E) Tests are written in NUnit and Playwright and accompany the project. The tests are designed to test the functionality of the application.
## Table of Contents
- [Technologies Used](#technologies-used)
- [Environment Setup](#environment-setup)
- [Executing the Web Application](#executing-the-web-application)
- [Executing Unit Tests](#executing-unit-tests)
- [Executing E2E Tests](#executing-e2e-tests)

## Technologies Used
The following technologies were used to create this application:
* [Blazor Server](https://learn.microsoft.com/en-us/aspnet/core/blazor/hosting-models?view=aspnetcore-8.0#blazor-server)
* [Bootstrap](https://getbootstrap.com/)
* [NUnit](https://nunit.org/)
* [Playwright for DotNet](https://playwright.dev/dotnet/)
* [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)

## Environment Setup
This cross-platform application is designed to work on Windows 10+, Mac-OS Ventura+, and Linux Environments. 

To prepare your environment:
* [Install .NET 8.0 from Microsoft](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

## Executing the Web Application
*FOLLOW THE STEPS IN [Environment Setup](#environment-setup) BEFORE TRYING TO EXECUTE THE APPLICATION* 

To execute the Web Application on your machine, there are 2 options:
* __Option 1: Installing JetBrains Rider (Easier Method if you don't understand the Command Line/Terminal Window)__
  * Step 1: Download [JetBrains Rider](https://www.jetbrains.com/rider/) (Community Version Will Suffice)
  * Step 2: Copy [this repository](https://github.com/DiegoFraR/Calculator) on GitHub. (Image Below)
  * Step 3: Open the repository in Rider.
  * Step 4: Ensure you are on the configuration to run the Web App Server on HTTPS. (See Below)
  * Step 5: Click the Green Arrow to run the application. You will be redirected to the application after a short start-up period.
    * If you are not redirected: [Click Here!](https://localhost:7037/)
 
* __Option 2: Through the Command Line (Faster Method)__
  * Step 1: Copy [this repository](https://github.com/DiegoFraR/Calculator) from GitHub using the following command:
    * ```bash
      git clone https://github.com/DiegoFraR/Calculator
      ```
  * Step 2: Navigate to this repository and specifically the folder titled "CalculatorWebApp"
  * Step 3: run ```dotnet test``` to run the application. You will be redirected to the application.
    * If you are not redirected: [Click Here!](https://localhost:7037/)
   
## Executing Unit Tests
To execute the Unit Tests on your machine, there are 2 options: 
* __Option 1: In JetBrains Rider (Easier Method if you don't understand the Command Line/Terminal Window)__
  * Step 1: In Rider, Navigate to the file "CalculatorUnitTests" under the CalculatorUnitTests Project Folder (See Image Below).
  * Step 2: Click the Green Arrow on the Class Definition line of code (See Image Below).
* __Option 2: Through the Command Line (Faster Method)__
  * Step 1: Navigate to the folder containing this repository.
  * Step 2: Navigate to the folder titled "CalculatorUnitTests".
  * Step 3: Run ```dotnet test``` to run the Unit Tests.

## Executing E2E Tests
__THE APP MUST BE RUNNING FOR THE E2E TESTS TO BE SUCCESSFUL__

To execute the E2E Tests on your machine, there are 2 options: 

* __Option 1: In JetBrains Rider (Easier Method if you don't understand the Command Line/Terminal Window)__
  * Step 1: In Rider, Navigate to the file "CalculatorE2ETests" under the CalculatorE2ETests Project Folder (See Image Below).
  * Step 2: Click the Green Arrow on the Class Definition line of code (See Image Below).
* __Option 2: Through the Command Line (Faster Method)__
  * Step 1: Navigate to the folder containing this repository.
  * Step 2: Navigate to the folder titled "CalculatorE2ETests".
  * Step 3: Run ```dotnet test``` to run the E2E Tests.

## Thanks for stopping by! 
Feel free to contact me here on GitHub or follow the links on my [Profile Page](https://github.com/DiegoFraR).
