using Creatures.Behaviours;

namespace Creatures
{
    public class Mob : Creature
    {
        IBehaviour _baseBehaviour;

        protected override void Start()
        {
            base.Start();
            _baseBehaviour = new Passive();
            _controller = new AIController();
            _controller.Init(GetBaseSettings());
        }

        protected override void Update()
        {
            base.Update();
        }

        protected override ControllerSettings GetBaseSettings()
        {
            var settings = new AIControllerSettings(Rigidbody, _view, _model, _baseBehaviour);

            return settings;
        }
    }
}