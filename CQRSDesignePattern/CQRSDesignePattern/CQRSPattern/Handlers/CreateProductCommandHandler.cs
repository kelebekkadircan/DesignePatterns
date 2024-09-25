using CQRSDesignePattern.CQRSPattern.Commands;
using CQRSDesignePattern.DAL;

namespace CQRSDesignePattern.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            _context.Add(new Product
            {
                Name = command.Name,
                Stock = command.Stock,
                Price = command.Price,
                Description = command.Description,
                Status = true
            });
            _context.SaveChanges();
        }
    }
}
