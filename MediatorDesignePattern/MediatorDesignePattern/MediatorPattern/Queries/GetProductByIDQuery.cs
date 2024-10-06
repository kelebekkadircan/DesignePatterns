using MediatorDesignePattern.MediatorPattern.Results;
using MediatR;

namespace MediatorDesignePattern.MediatorPattern.Queries
{
    public class GetProductByIDQuery : IRequest<GetProductByIdQueryResult>
    {
        public GetProductByIDQuery(int id)
        {
            ID = id;
        }

        public int ID  { get; set; }

    }
}
