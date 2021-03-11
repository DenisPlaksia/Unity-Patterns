

namespace Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public interface ICommandManager
    {
        bool IsUndo { get;  set; }
        void AddCommand(ICommand command);
        void UndoCommand();
    }
}

