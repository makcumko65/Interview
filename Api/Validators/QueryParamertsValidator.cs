using Api.Models;
using FluentValidation;

namespace Api.Validators
{
    public class QueryParamertsValidator : AbstractValidator<QueryParameters>
    {
        public QueryParamertsValidator()
        {
            RuleFor(q => q.Data)
                .NotNull()
                .NotEmpty()
                .WithMessage("Property reverse cannot be empty");
        }
    }
}
