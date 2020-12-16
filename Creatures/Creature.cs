using UnityEngine;

namespace Creatures
{
    [RequireComponent(typeof(Rigidbody2D), typeof(Collider2D), typeof(Animator))]
    public class Creature : MonoBehaviour
    {
        [SerializeField] protected Model _model;

        protected IController _controller;
        protected IView _view;

        protected Rigidbody2D Rigidbody => GetComponent<Rigidbody2D>();
        protected Animator Animator => GetComponent<Animator>();

        protected virtual void Start()
        {
            _view = new View();
            _view.Init(Animator);
        }

        protected virtual void Update()
        {
            _controller.Control();
        }

        protected virtual ControllerSettings GetBaseSettings()
        {
            var settings = new ControllerSettings(Rigidbody, _view, _model);

            return settings;
        }
    }
}