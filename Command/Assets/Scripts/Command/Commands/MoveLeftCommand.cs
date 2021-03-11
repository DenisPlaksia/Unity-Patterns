using UnityEngine;

namespace Command
{
    public class MoveLeftCommand : ICommand
    {
        private GameObject _player;
        private Vector3 previousPosition = Vector3.zero;
        
        public MoveLeftCommand(GameObject player)
        {
            _player = player;
        }
        
        public void Execute()
        {
            previousPosition = _player.transform.position;
            _player.transform.position += Vector3.left;
        }

        public void Undo()
        {
            _player.transform.position = previousPosition;
        }
    }
}