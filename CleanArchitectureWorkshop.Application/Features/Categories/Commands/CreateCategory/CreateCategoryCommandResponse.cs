using CleanArchitectureWorkshop.Application.Responses;

namespace CleanArchitectureWorkshop.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandResponse : BaseResponse
    {
        public CreateCategoryCommandResponse() : base()
        {
        }
        public CreateCategoryDto Category { get; set; }
    }
}
