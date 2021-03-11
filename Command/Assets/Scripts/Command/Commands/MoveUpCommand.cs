using UnityEngine;

namespace Command
{
    public class MoveUpCommand :ICommand
    {
        private GameObject _player;
        private Vector3 previousPosition = Vector3.zero;
        public MoveUpCommand(GameObject player)
        {
            _player = player;
        }
        
        public void Execute()
        {
            previousPosition = _player.transform.position;
            _player.transform.position += Vector3.up;
        }

        public void Undo()
        {
            _player.transform.position = previousPosition;
        }
    }
}