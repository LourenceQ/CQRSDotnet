using System.Windows.Input;

namespace Todo.Domain.Commands;

public class MarkTodoAsDoneCommand : Notifialbe, ICommand
{
    public Guid Id { get; set; }
    public string User { get; set; }
    public void Validate()
    {
        AddNotifications(
            new Contract()
                .Requires()
                .HasMinLen(User, 6, "User", "Usuário inválido.");
        );
    }
}