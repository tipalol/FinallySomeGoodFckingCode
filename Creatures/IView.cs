using UnityEngine;

namespace Creatures
{
    public interface IView
    {
        void Init(Animator animator);
        void Move();
        void Stop();
        void Attack();
        void Die();
    }
}