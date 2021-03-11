using UnityEngine;
namespace Command
{
    public class MoveRightCommand : ICommand
    {

        private GameObject _player;
        private Vector3 previousPosition = Vector3.zero;
        
        public MoveRightCommand(GameObject player)
        {
            _player = player;
        }
        
        public void Execute()
        {
            previousPosition = _player.transform.position;
            _player.transform.position += Vector3.right;
        }

        public void Undo()
        {
            _player.transform.position = previousPosition;
        }
    }
}