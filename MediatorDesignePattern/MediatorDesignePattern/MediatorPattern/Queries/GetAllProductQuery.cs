using MediatorDesignePattern.MediatorPattern.Results;
using MediatR;

namespace MediatorDesignePattern.MediatorPattern.Queries
{
    public class GetAllProductQuery: IRequest<List<GetAllProductQueryResult>>
    {

    }
}
