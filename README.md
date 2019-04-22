# Technology-lead-exercise1
This is the Retail Store Discounts Exercise

#Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

The exercise was done using Visual Studio Code.

#Prerequisites
1. Install Visual Studio Code
2. Install the .NET Core SDK
3. Install the C# extension for Visual Studio Code. For more information about how to install extensions on Visual Studio Code, see VS Code Extension Marketplace.


#Install and Configure Git
1. To install Git on Windows you will need to download the installer from the Git website:

Download the most current version for your operating system by double clicking on the package name

#Clone the source Repository
Please copy the below URL and paste it into your browser bar
https://github.com/chrisiregbu/technology-lead-exercise1

1. Clone the source repository from Github.
2. Open a terminal/console/command prompt, change to the directory where you cloned the repository and type:
cd build

#Building the code
1. Open Visual Studio Code and open the project folder 
2. Initialize a C# project:
    Open the Integrated Terminal from Visual Studio Code by selecting View > Integrated Terminal from the main menu.

    In the terminal window, type <dotnet new console>.
    
    This command creates a Program.cs file in your folder with a simple "Hello World" program already written, along with a C# project file named HelloWorld.csproj.

3. Resolve and build issues
   
   For .NET Core 1.x, type dotnet restore. Running dotnet restore gives you access to the required .NET Core packages that are needed to build your project.

    Note: Starting with .NET Core 2.0 SDK, you don't have to run dotnet restore because it's run implicitly by all commands that require a restore to occur, such as dotnet new, dotnet build and dotnet run.


4. Please ensure you have .NET runtime installed
5. .NET Core, NUnit and MsTest requires a dotnet sdk version of >= 2.1.2 and running dotnet tooling in english (see #77 for details).
6. Install VS Code for your platform and configure the tool set for your development needs
   
<Type dotnet run>   

#Running and testing the Program
1. The tests can be run from the Visual Studio code command line:
2. Press F5 to build the code
3. Navigate to the solution folder "TheRetailStoreDiscounts" and load it into Visual Studio Code IDE or any other IDE
4. From the toolbar menu select View > Terminal
5. To run the tests enter the command, <dotnet test> and you can check the status of the tests

