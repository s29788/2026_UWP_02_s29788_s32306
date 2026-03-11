using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private int _speed = 5;
        public Transform target;

        void Update()
        {
           
            if (Keyboard.current.dKey.isPressed)
            {
                transform.position += Vector3.right * (_speed * Time.deltaTime);
            }

            
            if (target != null)
            {
                target.transform.position = Vector3.zero;
            }
        }
    }
}