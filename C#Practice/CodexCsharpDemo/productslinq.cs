using System;
using System.Collections.Generic;
using System.Linq;

namespace CodexCsharpDemo;

/// <summary>
/// Represents an order used for customer spend calculations.
/// </summary>
/// <param name="Id">The order identifier.</param>
/// <param name="CustomerID">The customer identifier.</param>
/// <param name="OrderDate">The date the order was placed.</param>
/// <param name="TotalAmount">The total order amount.</param>
public sealed record Order(int Id, int CustomerID, DateTime OrderDate, decimal TotalAmount);

/// <summary>
/// Represents the total amount spent by a customer.
/// </summary>
/// <param name="CustomerID">The customer identifier.</param>
/// <param name="TotalAmount">The total amount spent by the customer.</param>
public sealed record CustomerSpendDto(int CustomerID, decimal TotalAmount);

/// <summary>
/// Provides LINQ queries for product order reporting.
/// </summary>
public static class ProductsLinq
{
    /// <summary>
    /// Gets the top 10 customers by total order amount for orders placed in 2026.
    /// </summary>
    /// <param name="orders">The source order collection.</param>
    /// <returns>The top 10 customer spend results ordered by total amount descending.</returns>
    public static List<CustomerSpendDto> GetTopCustomersBySpend(IEnumerable<Order> orders)
    {
        ArgumentNullException.ThrowIfNull(orders);

        return orders
            .Where(order => order.OrderDate.Year == 2026)
            .GroupBy(order => order.CustomerID)
            .Select(group => new CustomerSpendDto(
                CustomerID: group.Key,
                TotalAmount: group.Sum(order => order.TotalAmount)))
            .OrderByDescending(customer => customer.TotalAmount)
            .Take(10)
            .ToList();
    }
}
