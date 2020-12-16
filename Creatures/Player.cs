namespace Creatures
{
    public class Player : Creature
    {
        protected override void Start()
        {
            base.Start();
            _controller = new PlayerController();
            _controller.Init(GetBaseSettings());
        }

        protected override void Update()
        {
            base.Update();
        }
    }
}