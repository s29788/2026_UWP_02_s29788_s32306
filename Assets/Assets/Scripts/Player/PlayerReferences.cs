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

        private void Awake()
        {
            _playerController = GetComponent<PlayerController>();
            _playerData = GetComponent<PlayerData>();
            _inventory = GetComponent<Inventory>();
        }
    }
}

