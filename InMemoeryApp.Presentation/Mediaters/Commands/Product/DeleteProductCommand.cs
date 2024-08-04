using MediatR;

namespace InMemoeryApp.Presentation.Mediaters.Commands.Product
{
    public class DeleteProductCommand : IRequest<int>
    {
        public Guid Id { get; set; }
    }
}

/*
 xCommand  : IRequest<response>
 
 
 */