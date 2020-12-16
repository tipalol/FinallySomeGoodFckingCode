namespace Creatures.Behaviours
{
    public interface IBehaviour
    {
        void Init(AIController controller);
        void Do();
    }
}