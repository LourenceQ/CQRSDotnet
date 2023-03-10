using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands;

public class CreateTodoCommand : ICommand
{
    public CreateTodoCommand()
    {
    }

    public CreateTodoCommand(string title, string user, DateTime date)
    {
        Title = title;
        User = user;
        Date = date;
    }

    public string Title { get; set; }
    public string User { get; set; }
    public DateTime Date { get; set; }

    public bool Validate()
    {
        AddNotifications(
            new Contract().Requires.HasMinLen(Title, 3, "Title", "Favor decrever tarefa.")
            .HasMinLen(User, 6, "User", "Usuário inválido")
        );
        throw new NotImplementedException();
    }
}