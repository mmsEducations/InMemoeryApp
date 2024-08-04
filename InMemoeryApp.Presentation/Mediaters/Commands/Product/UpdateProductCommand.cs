using InMemoeryApp.Presentation.Data.Entities;
using MediatR;

namespace InMemoeryApp.Presentation.Mediaters.Commands.Product
{
    public class UpdateProductCommand : IRequest<int>
    {
        public Product Product { get; set; }
    }
}

/*
 xCommand  : IRequest<response>
 
 
 */