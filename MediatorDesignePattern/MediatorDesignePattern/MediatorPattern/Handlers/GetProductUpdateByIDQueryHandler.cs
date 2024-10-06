using MediatorDesignePattern.DAL;
using MediatorDesignePattern.MediatorPattern.Queries;
using MediatorDesignePattern.MediatorPattern.Results;
using MediatR;

namespace MediatorDesignePattern.MediatorPattern.Handlers
{
    
    public class GetProductUpdateByIDQueryHandler : IRequestHandler<GetProductUpdateByIDQuery, UpdateProductByIDQueryResult>
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public async Task<UpdateProductByIDQueryResult> Handle(GetProductUpdateByIDQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Products.FindAsync(request.ID);
            return new UpdateProductByIDQueryResult
            {
                ProductID = value.ProductID,
                ProductName = value.ProductName,
                ProductStock = value.ProductStock,
                ProductCategory = value.ProductCategory,
                ProductPrice = value.ProductPrice,
                ProductStockType = value.ProductStockType

            };


        }
    }
}
