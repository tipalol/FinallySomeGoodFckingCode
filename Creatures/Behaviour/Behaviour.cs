namespace Creatures.Behaviours
{
    public abstract class Behaviour : IBehaviour
    {
        protected AIController _controller;
        
        public abstract void Do();

        public virtual void Init(AIController controller)
        {
            _controller = controller;
        }
    }
}