using Player;
using UnityEngine;

namespace Items
{
    public class Coin : ItemBase
    {
        public override void OnCollected(PlayerReferences playerReferences)
        {
            if (playerReferences != null)
            {
                PlayerData playerData = playerReferences.GetPlayerData();
                if (playerData != null)
                {
                    playerData.AddScore(1);
                    Debug.Log("Zebrałem monetę! Razem: " + playerData.GetScore());
                }
            }
            Destroy(gameObject);
        }
    }
}