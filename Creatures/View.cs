using UnityEngine;

namespace Creatures
{
    public class View : IView
    {
        private Animator _animator;

        public void Init(Animator animator)
        {
            _animator = animator;
        }

        public void Attack()
            => _animator.SetTrigger("Attack");

        public void Die()
            => _animator.SetTrigger("Die");

        public void Move()
            => _animator.SetBool("IsMoving", true);

        public void Stop()
            => _animator.SetBool("IsMoving", false);
    }
}