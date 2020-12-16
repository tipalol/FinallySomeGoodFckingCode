using Creatures.Behaviours;

namespace Creatures
{
    public class AIController : Controller
    {
        private IBehaviour _behaviour;

        public override void Init(ControllerSettings settings)
        {
            base.Init(settings);
            _behaviour = ((AIControllerSettings)settings).Behaviour;
            _behaviour.Init(this);
        }

        public override void Control()
        {
            _behaviour.Do();
        }
    }
}