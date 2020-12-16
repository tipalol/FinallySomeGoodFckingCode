using System;
using UnityEngine;

namespace Creatures
{
    public abstract class Controller : IController
    {
        public event Action<Vector2> OnMoved;

        protected Rigidbody2D _rigidbody;

        protected IView _view;
        protected Model _model;

        public virtual void Init(ControllerSettings settings)
        {
            _rigidbody = settings.Rigidbody;
            _view = settings.View;
            _model = settings.Model;

            OnMoved += _model.UpdatePosition;
        }

        public abstract void Control();

        protected bool IsMoving
            => Mathf.Abs(_rigidbody.velocity.x) > 0.1f;

        public virtual void Move(float direction)
        {
            var velocity = _rigidbody.velocity;

            _rigidbody.velocity = new Vector2(direction * _model.Speed, velocity.y);

            OnMoved?.Invoke(_rigidbody.position);

            if (IsMoving == true)
                _view.Move();
            else
                _view.Stop();
        }
    }
}