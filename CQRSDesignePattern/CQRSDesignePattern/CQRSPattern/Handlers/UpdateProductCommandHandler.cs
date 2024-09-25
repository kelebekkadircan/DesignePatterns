using CQRSDesignePattern.CQRSPattern.Commands;
using CQRSDesignePattern.DAL;
using System;

namespace CQRSDesignePattern.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        
        public void Handle(UpdateProductCommand command)
        {
            var product = _context.Products.Find(command.ProductID);
            if (product == null)
            {
                throw new Exception("Product not found");
            }

            product.Name = command.Name;
            product.Stock = command.Stock;
            product.Price = command.Price;
            product.Description = command.Description;
            product.Status = true;

            _context.SaveChanges();
        }
    
    }
}
