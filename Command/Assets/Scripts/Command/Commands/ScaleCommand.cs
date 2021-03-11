using UnityEngine;

namespace Command
{
    public class ScaleCommand :ICommand
    {
        private GameObject _player;
        private Vector3 previousScale = Vector3.zero;
        
        public ScaleCommand(GameObject player)
        {
            _player = player;
        }
        
        public void Execute()
        {
            previousScale = _player.transform.localScale;
            _player.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
        }

        public void Undo()
        {
            _player.transform.localScale = previousScale;
        }
    }
}