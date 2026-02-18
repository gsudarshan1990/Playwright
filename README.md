Playwright Automation Practice

This repository comprises a collection of Playwright tests intended for the instruction and demonstration of web automation concepts utilizing TypeScript.

Projects

This repository is segmented into two primary projects:

PlaywrightBasicsTypeScript/:

A comprehensive suite of over twenty discrete test files (ranging from example.spec.ts to example21.spec.ts).

Each file is presumed to demonstrate a specific Playwright feature, locator strategy, or automation technique.

This serves as a valuable resource for a systematic study of Playwright.

playwrightdemo/:

A more concise demonstration project containing a few test files (example.spec.ts, test-1.spec.ts, test-2.spec.ts).

This project functions as a pragmatic, encapsulated example of a Playwright test suite.

Usage Instructions

To execute the tests within either project, please proceed with the following steps:

Clone the repository:

git clone <your-repository-url>
cd playwright


Navigate to a project directory:

# For the basic examples
cd PlaywrightBasicsTypeScript

# OR

# For the demo project
cd playwrightdemo


Install required dependencies:
(Prerequisite: Node.js must be installed on the local system.)

npm install


Install Playwright browser binaries:
(This process may execute automatically post-npm install; however, it can be initiated manually if required.)

npx playwright install


Execute the test suite:
This command initiates the execution of all test files located within the tests/ directory of the active project.

# Execute all tests in headless mode (default configuration)
npx playwright test

# Execute tests in headed mode for browser visualization
npx playwright test --headed

# Execute a specific test file
npx playwright test tests/example10.spec.ts

# View the generated HTML test report
npx playwright show-report


Key Files

tests/: This directory contains all test specification (.spec.ts) files.

playwright.config.ts: The primary configuration file for Playwright. This file defines project-level settings, browser configurations (Chromium, Firefox, WebKit), test timeouts, and reporter options.

package.json: Defines the project's Node.js dependencies, including the Playwright framework itself.
