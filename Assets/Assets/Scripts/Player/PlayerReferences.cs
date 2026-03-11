using Items;
using UnityEngine;

namespace Player
{
    public class PlayerReferences : MonoBehaviour
    {
        private PlayerController _playerController;
        private PlayerData _playerData;
        private Inventory _inventory;

        public PlayerController GetPlayerController() => _playerController;
        public PlayerData GetPlayerData() => _playerData;
        public Inventory GetInventory() => _inventory;

        private void OnValidate()
        {
            if (_playerController == null)
                _playerController = GetComponent<PlayerController>();
            if (_playerData == null)
                _playerData = GetComponent<PlayerData>();
            if (_inventory == null)
                _inventory = GetComponent<Inventory>();
        }
    }
}

