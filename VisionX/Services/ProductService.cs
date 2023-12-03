using System.Collections.Generic;
using System.Linq;
using VisionX.Data;
using VisionX.Models;

namespace VisionX.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var productToDelete = _context.Products.Find(productId);

            if (productToDelete != null)
            {
                // Check if there are any references to this product in the Patient entity
                bool hasReferences = _context.Invoices.Any(p => p.ProductID == productId);

                if (!hasReferences)
                {
                    _context.Products.Remove(productToDelete);
                    _context.SaveChanges();
                }
                else
                {
                    // Throw an exception indicating that the product has references and cannot be deleted
                    throw new InvalidOperationException($"Product with ID {productId} has references and cannot be deleted.");
                }
            }
            // Optionally, you can handle a case where the product is not found.
        }

        public void UpdateProductFee(int productId, int newFee)
        {
            var productToUpdate = _context.Products.Find(productId);

            if (productToUpdate != null)
            {
                productToUpdate.Fee = newFee;
                _context.SaveChanges();
            }
            // Optionally, you can handle a case where the product is not found.
        }

        public void UpdateProduct(int selectedProductID, Product updatedProduct)
        {
            var existingProduct = _context.Products.Find(selectedProductID);

            if (existingProduct != null)
            {
                // Update the properties of the existing product with the values from the updated product.
                existingProduct.Manufacturer = updatedProduct.Manufacturer;
                existingProduct.ModelNumber = updatedProduct.ModelNumber;
                existingProduct.Fee = updatedProduct.Fee;
                existingProduct.Type = updatedProduct.Type;
                // Add other properties as needed.

                _context.SaveChanges();
            }
            // Optionally, you can handle a case where the product is not found.
        }
    }
}