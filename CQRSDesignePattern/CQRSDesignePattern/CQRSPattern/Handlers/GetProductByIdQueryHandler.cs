using CQRSDesignePattern.CQRSPattern.Queries;
using CQRSDesignePattern.CQRSPattern.Results;
using CQRSDesignePattern.DAL;

namespace CQRSDesignePattern.CQRSPattern.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly  Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var values = _context.Set<Product>().Find(query.Id);
            return new GetProductByIDQueryResult
            {
                Name = values.Name,
                Price = values.Price,
                ProductID = values.ProductID,
                Stock = values.Stock
            };
        }

    }
}
