# Playwright Automation Practice

This repository contains a comprehensive collection of Playwright tests for web automation, featuring examples in multiple languages and frameworks including TypeScript, C#, HTML, and Gherkin.

## 📊 Repository Composition

- **HTML**: 71.7%
- **C#**: 18%
- **TypeScript**: 10.2%
- **Gherkin**: 0.1%

## 🎯 Projects

This repository is organized into four primary projects:

### 1. PlaywrightBasicsTypeScript/

A comprehensive suite of **25+ discrete test files** (ranging from `example.spec.ts` to `example23.spec.ts`, and recorder examples).

**Purpose**: Demonstrates specific Playwright features, locator strategies, and automation techniques in TypeScript.
**Key Files**: Located in the `tests/` directory.

### 2. playwrightdemo/

A concise demonstration project containing a few test files (`example.spec.ts`, `test-1.spec.ts`, `test-2.spec.ts`).

This project functions as a pragmatic, encapsulated example of a Playwright test suite.


A full-featured C# implementation of Playwright tests.

- **Features**: Includes Page Object Models (POM) for sites like OrangeHRM, Automation Exercise, and SwagLabs.
- **Test Framework**: Utilizes NUnit/MSTest/Xunit structures for various UI challenges (Checkboxes, Radio buttons, Alerts, etc.).

- ### 4. XunitBasics/

A dedicated project for learning unit testing and integration testing using the xUnit framework in C#.

**Content**: Includes examples of MemberData, Theory, and Fact attributes for data-driven testing.

---

## 🚀 Usage Instructions

### TypeScript Projects (PlaywrightBasicsTypeScript / playwrightdemo)

#### Clone the repository:
```bash
git clone <your-repository-url>
cd Playwright
```

#### Navigate to a project directory:
```bash
# For the basic examples
cd PlaywrightBasicsTypeScript

# OR

# For the demo project
cd playwrightdemo
```

#### Install required dependencies:
```bash
# Prerequisite: Node.js must be installed on the local system.
npm install
```

#### Install Playwright browser binaries:
```bash
# This process may execute automatically post-npm install
npx playwright install
```

#### Execute the test suite:
```bash
# Execute all tests in headless mode (default configuration)
npx playwright test

# Execute tests in headed mode for browser visualization
npx playwright test --headed

# Execute a specific test file
npx playwright test tests/example10.spec.ts

# View the generated HTML test report
npx playwright show-report

# Execute using codegen
npx playwright codegen <URL>
```

### C# Projects (PlaywrightCSharp / XunitBasics)

#### Navigate to directory:
```bash
cd PlaywrightCSharp
```

#### Restore packages:
```bash
dotnet restore
```

#### Build project:
```bash
dotnet build
```

#### Execute tests:
```bash
dotnet test
```

#### Execute specific tests:
```bash
# Single test file
dotnet test --filter "XunitBasics.CalculatorTest.cs"

# Single test with detailed output
dotnet test --filter "XunitBasics.ConsoleRunTests.cs" --logger "console;verbosity=detailed"
```

---

## 📁 Key Files

| File/Directory | Description |
|---|---|
| `tests/` | Contains all test specification (.spec.ts) files for TypeScript projects |
| `playwright.config.ts` | Primary configuration file for Playwright; defines project-level settings, browser configurations (Chromium, Firefox, WebKit), test timeouts, and reporter options |
| `pages/` | (Within PlaywrightCSharp) Contains reusable Page Object classes |
| `Playwright_Practice.csproj` | Project configuration for C# automation |
| `package.json` | Defines the project's Node.js dependencies, including the Playwright framework |

---

## ✨ Key Features

- **Multi-language support**: TypeScript, C#, and Gherkin examples
- **Multiple frameworks**: Playwright Test, xUnit, NUnit, MSTest
- **Page Object Models**: Reusable test components for maintainability
- **Comprehensive examples**: 25+ test scenarios covering various automation techniques
- **Data-driven testing**: Examples of parameterized and theory-based tests
- **Visual reporting**: HTML test reports and trace viewer integration
- **Cross-browser testing**: Support for Chromium, Firefox, and WebKit
- **Headless execution**: Full support for headless and headed modes

---

## 📚 Resources

- [Playwright Documentation](https://playwright.dev)
- [Playwright API Reference](https://playwright.dev/docs/api/class-playwright)
- [xUnit Documentation](https://xunit.net/)
- [Page Object Model Pattern](https://playwright.dev/docs/pom)
- [Playwright Best Practices](https://playwright.dev/docs/best-practices)

---

## 🛠️ Additional Information

### Browser Support

Playwright supports testing across three major browsers:

| Browser | Headless | Headed |
|---------|----------|--------|
| Chromium | ✅ | ✅ |
| Firefox | ✅ | ✅ |
| WebKit | ✅ | ✅ |

All browsers run on Linux, macOS, and Windows platforms.

### Test Configuration

The `playwright.config.ts` file allows you to configure:
- Browser launch options
- Test timeout settings
- Retry strategies
- Reporter formats (HTML, JSON, JUnit)
- Base URL for test applications
- Device emulation settings

### Debugging Tests

```bash
# Run tests in debug mode
npx playwright test --debug

# Use Playwright Inspector
npx playwright test --inspect

# Generate trace for failed tests
npx playwright test --trace on
```

### Recording Tests

Playwright provides a powerful code generation tool to record your actions:

```bash
# Start Playwright Codegen
npx playwright codegen <URL>

# Example: Generate tests for a website
npx playwright codegen https://example.com
```

---

## 🤝 Project Structure

```
Playwright/
├── PlaywrightBasicsTypeScript/
│   ├── tests/
│   │   ├── example.spec.ts
│   │   ├── example1.spec.ts
│   │   └── ... (25+ test files)
│   ├── playwright.config.ts
│   ├── package.json
│   └── node_modules/
│
├── playwrightdemo/
│   ├── tests/
│   │   ├── example.spec.ts
│   │   ├── test-1.spec.ts
│   │   └── test-2.spec.ts
│   └── package.json
│
├── PlaywrightCSharp/
│   ├── pages/
│   │   ├── OrangeHRMPage.cs
│   │   ├── AutomationExercisePage.cs
│   │   └── SwagLabsPage.cs
│   ├── tests/
│   │   ├── UITests.cs
│   │   └── AlertsTest.cs
│   ├── Playwright_Practice.csproj
│   └── obj/bin/
│
├── XunitBasics/
│   ├── CalculatorTest.cs
│   ├── ConsoleRunTests.cs
│   └── XunitBasics.csproj
│
└── README.md
```

---

## 📝 Getting Started

1. **Choose your language**: TypeScript or C#
2. **Navigate to the project directory**
3. **Install dependencies** (npm for TypeScript, dotnet for C#)
4. **Run the tests** using the commands provided above
5. **View the results** in the generated HTML report

---

## 🔧 Troubleshooting

### Issue: Playwright browsers not installed

**Solution**: Run the following command:
```bash
npx playwright install
```

### Issue: Tests timeout

**Solution**: Increase the timeout in your test file or config:
```bash
npx playwright test --timeout=30000
```

### Issue: Port already in use

**Solution**: Specify a different port or stop the process using that port.

### Issue: C# project build fails

**Solution**: Ensure .NET SDK is installed:
```bash
dotnet --version
dotnet restore
dotnet build --configuration Release
```

---

## 👤 Author

Created for learning and demonstrating web automation best practices using Playwright across multiple programming languages and frameworks.

---

## 📄 License

This repository is provided as an educational resource for learning Playwright automation testing.
