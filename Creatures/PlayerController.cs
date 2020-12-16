using UnityEngine;

namespace Creatures
{
    public class PlayerController : Controller
    {
        public override void Init(ControllerSettings settings)
        {
            base.Init(settings);
        }

        public override void Control()
        {
            var direction = Input.GetAxis("Horizontal");

            Move(direction);
        }
    }
}