using CQRSDesignePattern.CQRSPattern.Queries;
using CQRSDesignePattern.CQRSPattern.Results;
using CQRSDesignePattern.DAL;

namespace CQRSDesignePattern.CQRSPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler
    {
        private readonly Context _context;

            public GetProductUpdateByIDQueryHandler(Context context)
              {
            _context = context;
              }

        public GetProductUpdateQueryResult Handle(GetProductUpdateByIDQuery query)
            {
            var product = _context.Products.Find(query.ID);
            if (product == null)
            {
                return null;
            }
            return new GetProductUpdateQueryResult
            {
                ProductID = product.ProductID,
                Name = product.Name,
                Stock = product.Stock,
                Price = product.Price,
                Description = product.Description
            };
        }

    }
}
