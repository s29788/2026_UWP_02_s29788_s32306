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

                playerReferences.GetPlayerData().AddHp(healthAmount);
            }
            Destroy(gameObject);
        }
    }
}


