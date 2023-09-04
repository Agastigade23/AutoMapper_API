using FluentValidation;

namespace AutoMapper_API.Handlers.Queries
{
    public class GetPersonByIdQueryValidator   : AbstractValidator<GetPersonByIdQuery>
    {
        public GetPersonByIdQueryValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
