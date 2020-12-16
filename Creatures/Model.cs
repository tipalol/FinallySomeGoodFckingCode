using UnityEngine;

namespace Creatures
{
    [System.Serializable]
    public class Model
    {
        public float Health;
        public float Speed;
        public Vector2 Position;

        public void UpdatePosition(Vector2 position)
            => Position = position;
    }
}