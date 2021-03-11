using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class CommandManager : MonoBehaviour, ICommandManager
    {
        public static CommandManager Instanse;
        public bool IsUndo { get; set; } = true;

        private List<ICommand> _commands = new List<ICommand>();
        public void Awake()
        {
            Instanse = this;
        }

        public void AddCommand(ICommand command)
        {
            command.Execute();
            _commands.Add(command);
        }

        private IEnumerator UndoCommands()
        {
            _commands.Reverse();
            foreach (var command in _commands)
            {
                command.Undo();
                yield return new WaitForSeconds(0.1f);
            }
            _commands.Clear();
            IsUndo = true;
        }
        
        public void UndoCommand()
        {
            IsUndo = false;
            StartCoroutine(UndoCommands());
        }
    }
}