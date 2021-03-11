

namespace Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public interface ICommandManager
    {
        void AddCommand(ICommand command);
    }
}

