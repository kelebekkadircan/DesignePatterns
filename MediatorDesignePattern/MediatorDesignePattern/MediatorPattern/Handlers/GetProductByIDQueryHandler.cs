using MediatorDesignePattern.DAL;
using MediatorDesignePattern.MediatorPattern.Queries;
using MediatorDesignePattern.MediatorPattern.Results;
using MediatR;

namespace MediatorDesignePattern.MediatorPattern.Handlers
{
    public class GetProductByIDQueryHandler : IRequestHandler<GetProductByIDQuery, GetProductByIdQueryResult>
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public async Task<GetProductByIdQueryResult> Handle(GetProductByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.ID);
            return new GetProductByIdQueryResult
            {
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                ProductStock = values.ProductStock
            };
        }
    }
}
