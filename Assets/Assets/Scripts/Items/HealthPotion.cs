using Player;
using UnityEngine;
namespace Items
{
    public class HealthPotion : ItemBase
    {
        [SerializeField] private int healthAmount = 25;

        public override void OnCollected(PlayerReferences playerReferences)
        {
            if (playerReferences != null)
            {
                PlayerData playerData = playerReferences.GetPlayerData();
                if (playerData != null)
                {
                    playerReferences.GetPlayerData().AddHp(healthAmount);
                    Debug.Log("Leczenie! hp: " + playerData.GetHp());
                }
            }
            Destroy(gameObject);
        }
    }
}


