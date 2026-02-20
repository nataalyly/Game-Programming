using UnityEngine;

namespace Apps.Scripts
{
    public class JumpAction : MonoBehaviour, ICharacterAction<bool>
    {
        [SerializeField] private float jumpForce = 5f;

        private Rigidbody _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            if (_rb is null) Debug.LogWarning("No Rigidbody attached to the object", this);
        }

        public void Execute(bool isJumping)
        {
            if (!isJumping) return;
            if (_rb == null) return;

            _rb.linearVelocity = new Vector3(
                _rb.linearVelocity.x,
                jumpForce,
                _rb.linearVelocity.z
            );
        }
    }
}