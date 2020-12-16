using UnityEngine;

namespace Creatures.Behaviours
{
    public class Passive : Behaviour
    {
        private Vector2 _targetPoint;

        public override void Init(AIController controller)
        {
            base.Init(controller);
            _targetPoint = new Vector2(-1, 0);
        }

        public override void Do()
        {
            _controller.Move(_targetPoint.x);
        }
    }
}