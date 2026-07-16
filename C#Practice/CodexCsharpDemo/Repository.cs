using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CodexCsharpDemo;

/// <summary>
/// Defines basic asynchronous data access operations for an entity.
/// </summary>
/// <typeparam name="TEntity">The entity type managed by the repository.</typeparam>
public interface IRepository<TEntity>
{
    /// <summary>
    /// Gets an entity by its unique identifier.
    /// </summary>
    /// <param name="id">The entity identifier.</param>
    /// <returns>The entity when found; otherwise, null.</returns>
    Task<TEntity?> GetByIDAsync(int id);

    /// <summary>
    /// Gets all entities.
    /// </summary>
    /// <returns>A read-only collection of entities.</returns>
    Task<IReadOnlyList<TEntity>> GetAllAsync();

    /// <summary>
    /// Adds a new entity.
    /// </summary>
    /// <param name="entity">The entity to add.</param>
    /// <returns>The added entity.</returns>
    Task<TEntity> AddAsync(TEntity entity);

    /// <summary>
    /// Updates an existing entity.
    /// </summary>
    /// <param name="entity">The entity with updated values.</param>
    /// <returns>The updated entity.</returns>
    Task<TEntity> UpdateAsync(TEntity entity);

    /// <summary>
    /// Deletes an entity by its unique identifier.
    /// </summary>
    /// <param name="id">The entity identifier.</param>
    Task DeleteAsync(int id);
}

/// <summary>
/// Provides Entity Framework Core data access for products.
/// </summary>
public sealed class ProductRepository : IRepository<Product>
{
    private readonly AppDbContext _dbContext;
    private readonly ILogger<ProductRepository> _logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    /// <param name="logger">The repository logger.</param>
    public ProductRepository(AppDbContext dbContext, ILogger<ProductRepository> logger)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    /// <inheritdoc />
    public async Task<Product?> GetByIDAsync(int id)
    {
        var product = await _dbContext.Products.AsNoTracking().FirstOrDefaultAsync(product => product.Id == id);

        if (product is null)
        {
            _logger.LogWarning("Product with id {ProductId} was not found.", id);
        }

        return product;
    }

    /// <inheritdoc />
    public async Task<IReadOnlyList<Product>> GetAllAsync()
    {
        return await _dbContext.Products.AsNoTracking().ToListAsync();
    }

    /// <inheritdoc />
    public async Task<Product> AddAsync(Product product)
    {
        ArgumentNullException.ThrowIfNull(product);

        await _dbContext.Products.AddAsync(product);
        await _dbContext.SaveChangesAsync();

        _logger.LogInformation("Product with id {ProductId} was added.", product.Id);
        return product;
    }

    /// <inheritdoc />
    public async Task<Product> UpdateAsync(Product product)
    {
        ArgumentNullException.ThrowIfNull(product);

        var existingProduct = await _dbContext.Products.FindAsync(product.Id);
        if (existingProduct is null)
        {
            _logger.LogWarning("Product with id {ProductId} could not be updated because it was not found.", product.Id);
            throw new KeyNotFoundException($"Product with id {product.Id} was not found.");
        }

        existingProduct.Name = product.Name;
        existingProduct.Description = product.Description;
        existingProduct.Price = product.Price;
        existingProduct.IsActive = product.IsActive;
        existingProduct.CreatedAtUtc = product.CreatedAtUtc;

        await _dbContext.SaveChangesAsync();

        _logger.LogInformation("Product with id {ProductId} was updated.", product.Id);
        return existingProduct;
    }

    /// <inheritdoc />
    public async Task DeleteAsync(int id)
    {
        var product = await _dbContext.Products.FindAsync(id);
        if (product is null)
        {
            _logger.LogWarning("Product with id {ProductId} could not be deleted because it was not found.", id);
            throw new KeyNotFoundException($"Product with id {id} was not found.");
        }

        _dbContext.Products.Remove(product);
        await _dbContext.SaveChangesAsync();

        _logger.LogInformation("Product with id {ProductId} was deleted.", id);
    }
}
