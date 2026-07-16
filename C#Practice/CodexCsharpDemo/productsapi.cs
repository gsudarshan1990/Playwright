using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace CodexCsharpDemo;

/// <summary>
/// Maps product endpoints for the minimal API.
/// </summary>
public static class ProductsApi
{
    /// <summary>
    /// Adds product API routes to the application.
    /// </summary>
    /// <param name="app">The endpoint route builder.</param>
    /// <returns>The endpoint route builder.</returns>
    public static IEndpointRouteBuilder MapProductEndpoints(this IEndpointRouteBuilder app)
    {
        var products = app.MapGroup("/products").WithTags("Products");

        products.MapGet("", async (IRepository<Product> repository) =>
        {
            var allProducts = await repository.GetAllAsync();
            return Results.Ok(allProducts);
        });

        products.MapGet("/{id:int}", async (int id, IRepository<Product> repository) =>
        {
            var product = await repository.GetByIDAsync(id);
            return product is null ? Results.NotFound() : Results.Ok(product);
        });

        products.MapPost("", async (Product product, IRepository<Product> repository) =>
        {
            // Validate the incoming product before saving it.
            var validationErrors = ValidateProduct(product);
            if (validationErrors.Count > 0)
            {
                return Results.ValidationProblem(validationErrors);
            }

            var createdProduct = await repository.AddAsync(product);
            return Results.Created($"/products/{createdProduct.Id}", createdProduct);
        });

        products.MapPut("/{id:int}", async (int id, Product product, IRepository<Product> repository) =>
        {
            if (id != product.Id)
            {
                return Results.BadRequest("Route id must match the product id.");
            }

            // Validate the updated product before applying changes.
            var validationErrors = ValidateProduct(product);
            if (validationErrors.Count > 0)
            {
                return Results.ValidationProblem(validationErrors);
            }

            try
            {
                var updatedProduct = await repository.UpdateAsync(product);
                return Results.Ok(updatedProduct);
            }
            catch (KeyNotFoundException)
            {
                return Results.NotFound();
            }
        });

        products.MapDelete("/{id:int}", async (int id, IRepository<Product> repository) =>
        {
            try
            {
                await repository.DeleteAsync(id);
                return Results.NoContent();
            }
            catch (KeyNotFoundException)
            {
                return Results.NotFound();
            }
        });

        return app;
    }

    private static Dictionary<string, string[]> ValidateProduct(Product product)
    {
        var validationResults = new List<ValidationResult>();
        var validationContext = new ValidationContext(product);

        Validator.TryValidateObject(product, validationContext, validationResults, validateAllProperties: true);

        return validationResults
            .GroupBy(result => result.MemberNames.FirstOrDefault() ?? string.Empty)
            .ToDictionary(
                group => group.Key,
                group => group.Select(result => result.ErrorMessage ?? "The value is invalid.").ToArray());
    }
}
