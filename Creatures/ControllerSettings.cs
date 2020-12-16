using UnityEngine;

namespace Creatures
{
    public class ControllerSettings
    {
        public Rigidbody2D Rigidbody { get; private set; }
        public IView View { get; private set; }
        public Model Model { get; private set; }

        public ControllerSettings(Rigidbody2D rigidbody, IView view, Model model)
        {
            Rigidbody = rigidbody;
            View = view;
            Model = model;
        }
    }
}