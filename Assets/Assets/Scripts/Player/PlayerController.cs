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
            if (Keyboard.current.aKey.isPressed)
            {
                transform.position += Vector3.left * (_speed * Time.deltaTime);
            }

            if (Keyboard.current.wKey.isPressed)
            {
                transform.position += Vector3.up * (_speed * Time.deltaTime);
            }
            if (Keyboard.current.sKey.isPressed)
            {
                transform.position += Vector3.down * (_speed * Time.deltaTime);
            }
            if (target != null)
            {
                target.transform.position = Vector3.zero;
            }
        }
    }
}