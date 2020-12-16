using UnityEngine;
using Creatures.Behaviours;

namespace Creatures
{
    public class AIControllerSettings : ControllerSettings
    {
        public IBehaviour Behaviour;

        public AIControllerSettings(Rigidbody2D rigidbody, IView view, Model model, IBehaviour behaviour) : base(rigidbody, view, model)
        {
            Behaviour = behaviour;
        }
    }
}