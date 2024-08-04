using MediatR;

namespace InMemoeryApp.Presentation.Mediaters.Commands.Product
{
    //CreateProductCommand->request , <int>-> Response
    public class CreateProductCommand : IRequest<int>
    {
        public Product Product { get; set; }
    }
}

/*
 xCommand  : IRequest<response>
 
 
 */