using Player;
using UnityEngine;

namespace Items
{
    public class ItemBase : MonoBehaviour, IInteractable
    {
        [SerializeField] private PlayerController player;
        void Update()
        {
            float distance = Vector3.Distance(player.transform.position, transform.position);

            if (distance < 1f)
            {
                Interact();
            }
        }

        public void Interact()
        {
            
        }
    }
}