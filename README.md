# Playwright Automation Practice

This repository comprises a collection of Playwright tests intended for the instruction and demonstration of web automation concepts utilizing TypeScript.

## Projects

This repository is segmented into two primary projects:

### PlaywrightBasicsTypeScript/:

A comprehensive suite of over **twenty-five** discrete test files (ranging from example.spec.ts to example23.spec.ts, and recorder examples).

**Purpose**: Demonstrates specific Playwright features, locator strategies, and automation techniques in TypeScript.

**Key Files**: Located in the **tests/** directory.

playwrightdemo/:

A more concise demonstration project containing a few test files (example.spec.ts, test-1.spec.ts, test-2.spec.ts).

This project functions as a pragmatic, encapsulated example of a Playwright test suite.

**2. PlaywrightCSharp/**
A full-featured C# implementation of Playwright tests.

- **Features**: Includes Page Object Models (POM) for sites like OrangeHRM, Automation Exercise, and SwagLabs.

- **Test Framework**: Utilizes NUnit/MSTest/Xunit structures for various UI challenges (Checkboxes, Radio buttons, Alerts, etc.).

**3. XunitBasics/**
A dedicated project for learning unit testing and integration testing using the xUnit framework in C#.

Content: Includes examples of MemberData, Theory, and Fact attributes for data-driven testing.
- 

Usage Instructions

To execute the tests within either project, please proceed with the following steps:

Clone the repository:

`git clone <your-repository-url>`
`cd playwright`


Navigate to a project directory:

# For the basic examples
`cd PlaywrightBasicsTypeScript`

# OR

# For the demo project
`cd playwrightdemo`


Install required dependencies:
(Prerequisite: Node.js must be installed on the local system.)

`npm install`


Install Playwright browser binaries:
(This process may execute automatically post-npm install; however, it can be initiated manually if required.)

`npx playwright install`


Execute the test suite:
This command initiates the execution of all test files located within the tests/ directory of the active project.

# Execute all tests in headless mode (default configuration)
`px playwright test`

# Execute tests in headed mode for browser visualization
`npx playwright test --headed`

# Execute a specific test file
`npx playwright test tests/example10.spec.ts`

# View the generated HTML test report
`npx playwright show-report`
# Execute using the codegen
`npx playwright codegen URL`


*8C# Project (PlaywrightCSharp)**
Navigate to directory: `cd PlaywrightCSharp`

Restore packages: `dotnet restore`

Build project: `dotnet build`

Execute tests: `dotnet test`

Single tests : `dotnet test --filter "XunitBasics.CalculatorTest.cs"`

Single tests with ITestOutputHelper: `dotnet test --filter "XunitBasics.ConsoleRunTests.cs" --logger "console;verbosity=detailed"`

# Key Files

**tests/**: This directory contains all test specification (.spec.ts) files.

**playwright.config.ts**: The primary configuration file for Playwright. This file defines project-level settings, browser configurations (Chromium, Firefox, WebKit), test timeouts, and reporter options.

**pages/**: (Within PlaywrightCSharp) Contains reusable Page Object classes.

**Playwright_Practice.csproj**: Project configuration for C# automation.

**package.json** : Defines the project's Node.js dependencies, including the Playwright framework itself.
