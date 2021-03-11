using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class CommandManager : MonoBehaviour
    {
        public static CommandManager Instanse;
        public bool isUndo = true;

        public List<ICommand> Commands = new List<ICommand>();
        public void Awake()
        {
            Instanse = this;
        }

        public void AddCommand(ICommand command)
        {
            command.Execute();
            Commands.Add(command);
        }

        private IEnumerator UndoCommands()
        {
            Commands.Reverse();
            foreach (var command in Commands)
            {
                command.Undo();
                yield return new WaitForSeconds(0.1f);
            }
            Commands.Clear();
            isUndo = true;
        }
        
        public void UndoCommand()
        {
            isUndo = false;
            StartCoroutine(UndoCommands());
        }
    }
}