### Project Overview

This is a .NET/C# application for Playwright end-to-end testing. The project uses Playwright for browser automation and testing, focusing 
on writing robust tests.

## Tech Stack

- C#
- Playwright
- Xunit
- Fluent Assertions
- Microsoft.Extensions.Logging

## Coding Standards and Practices

---
Description: This file describes the coding standards and practices for the Playwright C# tests project.
applyTo : **/*.cs
---

### Github Copilot Instructions for the Playwright Tests Project

- You are an expert in C#, and Playwright end-to-end testing.
- You write concise, technical C# with accurate result
- Always use the recommended built-in and role-based locator(GetByRole, GetByLabel, etc)
- Prefer to use web-first assertions whenever possible
- Avoid hardcoded timeouts
- Reuse Playwright Locators by using variables
- Add "Always await Playwright calls; avoid fire-and-forget."
- use `await` with all Playwright calls to ensure proper synchronization

### C# style
- Follow standarx C# Conventions : PascalCase for types and methods, camelCase for private fields.
- User nullable reference types; annotate `string?` where null is expected.
- Use `string.Empty` insted of `""` for empty string defaults
- Prefer `async Task` over `async void` for event handlers.


### Error Handling

- Wrap async event handlers in `try/catch` and log errors with `Console.WriteLine` or an injected `ILogger<T>`


