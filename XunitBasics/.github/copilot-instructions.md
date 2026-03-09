### Project Overview

This is a .NET/C# application using xUnit for unit and integration testing. The project focuses on writing robust, maintainable tests with clear assertions and proper error handling.

## Tech Stack

- C#
- xUnit
- Fluent Assertions
- Microsoft.Extensions.Logging
- Moq (for mocking)

## Coding Standards and Practices

---
Description: This file describes the coding standards and practices for the xUnit C# tests project.
applyTo : **/*.cs
---

### Github Copilot Instructions for the xUnit Tests Project

- You are an expert in C#, and xUnit testing best practices.
- You write concise, technical C# with accurate results.
- Write descriptive test names following the pattern: `MethodName_Scenario_ExpectedResult`.
- Use Fluent Assertions for clear, readable assertions.
- Arrange-Act-Assert (AAA) pattern for test structure.
- Create reusable fixtures and test data builders for common test scenarios.
- Avoid test interdependencies; each test must be independent and isolated.
- Use `IAsyncLifetime` for async setup and teardown operations.
- Always await async operations; avoid fire-and-forget patterns.

### C# Style

- Follow standard C# Conventions: PascalCase for types and methods, camelCase for private fields.
- Use nullable reference types; annotate `string?` where null is expected.
- Use `string.Empty` instead of `""` for empty string defaults.
- Prefer `async Task` over `async void` for event handlers and async operations.
- Use `[Fact]` for tests with no parameters and `[Theory]` with `[InlineData]` for parameterized tests.

### Error Handling

- Wrap async operations in `try/catch` and log errors with `Console.WriteLine` or an injected `ILogger<T>`.
- Use `Assert.Throws<T>` or `Assert.ThrowsAsync<T>` for exception testing.
- Document expected exceptions in test comments when appropriate.

### Test Structure

- One assertion concept per test (or use Fluent Assertions for multiple related assertions).
- Use xUnit's `[SetUp]` equivalent via constructors or `IAsyncLifetime` for initialization.
- Clean up resources using `IDisposable` or `IAsyncDisposable` patterns.
- Use `Theory` tests with `MemberData` or `ClassData` for complex test scenarios.

### Mocking and Isolation

- Use Moq for creating mocks and stubs.
- Mock external dependencies; test the unit in isolation.
- Verify mock interactions only when behavior testing is necessary.
- Keep mocks simple and focused on the specific test scenario.