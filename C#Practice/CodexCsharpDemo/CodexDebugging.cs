using System;

namespace CodexCsharpDemo;

/// <summary>
/// Demonstrates a null-safe product formatting method.
/// </summary>
public static class CodexDebugging
{
    /// <summary>
    /// Builds a short display summary for a product.
    /// </summary>
    /// <param name="product">The product to summarize.</param>
    /// <returns>A formatted product summary.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="product"/> is null.</exception>
    public static string BuildProductSummary(Product product)
    {
        ArgumentNullException.ThrowIfNull(product);

        var name = string.IsNullOrWhiteSpace(product.Name) ? "Unnamed product" : product.Name.Trim();
        var description = string.IsNullOrWhiteSpace(product.Description) ? "No description" : product.Description.Trim();
        var status = product.IsActive ? "Active" : "Inactive";

        return $"{name} - {description} - {product.Price:C} - {status}";
    }
}

/// <summary>
/// Lightweight tests for <see cref="CodexDebugging"/>.
/// </summary>
public static class CodexDebuggingTests
{
    /// <summary>
    /// Runs the Codex debugging tests.
    /// </summary>
    public static void RunAll()
    {
        BuildProductSummaryThrowsWhenProductIsNull();
        BuildProductSummaryHandlesNullProductName();
        BuildProductSummaryHandlesNullProductDescription();
        BuildProductSummaryFormatsValidProduct();
    }

    private static void BuildProductSummaryThrowsWhenProductIsNull()
    {
        AssertThrows<ArgumentNullException>(() => CodexDebugging.BuildProductSummary(null!));
    }

    private static void BuildProductSummaryHandlesNullProductName()
    {
        var product = new Product
        {
            Name = null!,
            Description = "Keyboard",
            Price = 49.99m,
            IsActive = true
        };

        var result = CodexDebugging.BuildProductSummary(product);

        AssertContains(result, "Unnamed product");
        AssertContains(result, "Keyboard");
    }

    private static void BuildProductSummaryHandlesNullProductDescription()
    {
        var product = new Product
        {
            Name = "Mouse",
            Description = null,
            Price = 19.99m,
            IsActive = true
        };

        var result = CodexDebugging.BuildProductSummary(product);

        AssertContains(result, "Mouse");
        AssertContains(result, "No description");
    }

    private static void BuildProductSummaryFormatsValidProduct()
    {
        var product = new Product
        {
            Name = " Monitor ",
            Description = " 27 inch display ",
            Price = 199.99m,
            IsActive = false
        };

        var result = CodexDebugging.BuildProductSummary(product);

        AssertContains(result, "Monitor");
        AssertContains(result, "27 inch display");
        AssertContains(result, "Inactive");
    }

    private static void AssertContains(string value, string expected)
    {
        if (!value.Contains(expected, StringComparison.Ordinal))
        {
            throw new InvalidOperationException($"Expected '{value}' to contain '{expected}'.");
        }
    }

    private static void AssertThrows<TException>(Action action)
        where TException : Exception
    {
        try
        {
            action();
        }
        catch (TException)
        {
            return;
        }

        throw new InvalidOperationException($"Expected exception of type {typeof(TException).Name}.");
    }
}
