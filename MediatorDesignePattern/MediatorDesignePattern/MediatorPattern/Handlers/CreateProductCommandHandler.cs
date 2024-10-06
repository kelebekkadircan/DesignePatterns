using MediatorDesignePattern.MediatorPattern.Commands;
using MediatR;
using MediatorDesignePattern.DAL;


namespace MediatorDesignePattern.MediatorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                ProductName = request.ProductName,
                ProductStock = request.ProductStock,
                ProductStockType = request.ProductStockType,
                ProductPrice = request.ProductPrice,
                ProductCategory = request.ProductCategory
            });
            await _context.SaveChangesAsync();
        }
    }
}
