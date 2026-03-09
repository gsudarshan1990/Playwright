### Project Overview

This is a TypeScript application for Playwright end-to-end testing. The project uses Playwright for browser automation and testing, focusing on writing robust tests.

## Tech Stack

- TypeScript
- Playwright
- Jest or Mocha
- Assertions Library
- Logging

## Coding Standards and Practices

---
Description: This file describes the coding standards and practices for the Playwright TypeScript tests project.
applyTo : **/*.ts
---

### Github Copilot Instructions for the Playwright Tests Project

- You are an expert in TypeScript and Playwright end-to-end testing.
- You write concise, technical TypeScript with accurate results.
- Always use the recommended built-in and role-based locator (getByRole, getByLabel, etc).
- Prefer to use web-first assertions whenever possible.
- Avoid hardcoded timeouts.
- Reuse Playwright Locators by using variables.
- Always await Playwright calls; avoid fire-and-forget.
- Use `await` with all Playwright calls to ensure proper synchronization.

### TypeScript Style

- Follow standard TypeScript conventions: PascalCase for types and classes, camelCase for variables and functions, UPPER_SNAKE_CASE for constants.
- Use strict typing; avoid `any` type unless absolutely necessary.
- Use `string | undefined` or `string | null` for nullable types.
- Use empty string defaults with `string.Empty` equivalent or empty string literals appropriately.
- Prefer `async function` or arrow functions returning `Promise<T>` over callbacks.
- Use descriptive variable names for clarity.

### Error Handling

- Wrap async operations in `try/catch` blocks and log errors with `console.error()` or an injected logger.
- Provide meaningful error messages for debugging.
- Handle promise rejections gracefully.

### Test Structure

- Use descriptive test names that clearly indicate what is being tested.
- Follow the Arrange-Act-Assert pattern for test organization.
- Keep tests focused and independent.
- Avoid test interdependencies.

### Best Practices

- Reuse page objects or helper functions to reduce code duplication.
- Maintain test data separately from test logic.
- Use configuration files for environment-specific settings.
- Document complex test scenarios with comments.