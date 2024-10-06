using MediatorDesignePattern.DAL;
using MediatorDesignePattern.MediatorPattern.Queries;
using MediatorDesignePattern.MediatorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MediatorDesignePattern.MediatorPattern.Handlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>
    {
        private readonly Context _context;

        public GetAllProductQueryHandler(Context context)
        {
            _context = context;
        }
        public  async Task<List<GetAllProductQueryResult>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GetAllProductQueryResult
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                ProductStock = x.ProductStock,
                ProductStockType = x.ProductStockType

            }).AsNoTracking().ToListAsync();

        }
    }
}
