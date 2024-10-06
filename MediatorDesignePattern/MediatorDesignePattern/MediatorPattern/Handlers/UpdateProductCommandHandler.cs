using MediatorDesignePattern.DAL;
using MediatorDesignePattern.MediatorPattern.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc.Routing;
using NuGet.Protocol.Plugins;

namespace MediatorDesignePattern.MediatorPattern.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.ProductID);
            values.ProductName = request.ProductName;
            values.ProductStock = request.ProductStock;
            values.ProductStockType = request.ProductStockType;
            values.ProductPrice = request.ProductPrice;
            values.ProductCategory = request.ProductCategory;
            await _context.SaveChangesAsync();

        }
    }
}
