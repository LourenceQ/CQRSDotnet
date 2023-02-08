using Flunt.Validations;

namespace Todo.Domain.Commands.Contracts;

public interface ICommand 
{
    bool Validate();
}