using MediatorDesignePattern.MediatorPattern.Results;
using MediatR;

namespace MediatorDesignePattern.MediatorPattern.Queries
{
    public class GetProductUpdateByIDQuery : IRequest<UpdateProductByIDQueryResult>
    {
        public GetProductUpdateByIDQuery(int id)
        {
            ID = id;
        }
        public int ID { get; set; }

    }
}
