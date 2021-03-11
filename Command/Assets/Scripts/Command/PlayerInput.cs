using System;
using UnityEngine;

namespace Command
{
    public class PlayerInput : MonoBehaviour
    {
        private ICommand command;
        public void Update()
        {
            if (CommandManager.Instanse.IsUndo)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    CommandManager.Instanse.AddCommand(new MoveUpCommand(gameObject));
                }

                if (Input.GetKeyDown(KeyCode.S))
                {
                    CommandManager.Instanse.AddCommand(new ScaleCommand(gameObject));
                }

                if (Input.GetKeyDown(KeyCode.A))
                {
                    CommandManager.Instanse.AddCommand(new MoveLeftCommand(gameObject));
                }

                if (Input.GetKeyDown(KeyCode.D))
                {
                    CommandManager.Instanse.AddCommand(new MoveRightCommand(gameObject));
                }

                if (Input.GetKeyDown(KeyCode.R))
                {
                    CommandManager.Instanse.UndoCommand();
                }
            }
        }
    }
}