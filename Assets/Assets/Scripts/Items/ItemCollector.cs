using Player;
using UnityEngine;
namespace Items
{
    public class ItemCollector : MonoBehaviour
    {
        private PlayerReferences _playerReferences;

        private void Awake()
        {
            _playerReferences = GetComponent<PlayerReferences>();
        }

        private void OnTriggerEnter(Collider collision)
        {
            ItemBase item = collision.GetComponent<ItemBase>();
            if (item != null)
            {
                if (_playerReferences != null)
                {
                    item.OnCollected(_playerReferences);
                }
            }
        }
        public PlayerReferences GetPlayerReferences() => _playerReferences;
    }
}