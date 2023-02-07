using Flunt.Validations;

namespace Todo.Domain.Commands.Contracts;

public interface ICommand : IValidatableObject
{
    bool Validate();
}