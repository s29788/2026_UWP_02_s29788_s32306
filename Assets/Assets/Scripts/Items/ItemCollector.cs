using Player;
using UnityEngine;
namespace Items
{
    public class ItemCollector : MonoBehaviour
    {
        private PlayerReferences _playerReferences;

        private void Start()
        {
            _playerReferences = GetComponent<PlayerReferences>();
        }
        private void OnTriggerEnter(Collider collision)
        {
            ItemBase item = collision.GetComponent<ItemBase>();
            if (item != null && _playerReferences != null)
            {
                item.OnCollected(_playerReferences);
            }
        }
    }
}