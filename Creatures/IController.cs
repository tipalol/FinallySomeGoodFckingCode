namespace Creatures
{
    public interface IController
    {
        void Init(ControllerSettings settings);
        void Control();
    }
}