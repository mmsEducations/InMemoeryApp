using MediatR;

namespace InMemoeryApp.Presentation.Mediaters.Queries.Product
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public Guid Id { get; set; }
    }
}


//query : IRequest<Dönen Veri tipi>

/*

public class GetAllProductsQuery : IRequest<IEnumerable<Product>>
{
    //request parameters add to this block
}

GetAllProductsQuery   : Request 
IEnumerable<Product>  : Response

*/