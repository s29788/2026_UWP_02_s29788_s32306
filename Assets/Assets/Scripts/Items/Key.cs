using Player;
using UnityEngine;
namespace Items
{
    public class Key : ItemBase
    {
        public override void OnCollected(PlayerReferences playerReferences)
        {
            if (playerReferences != null)
            {
                playerReferences.GetInventory().AddKey(this);
                Debug.Log("Zebrano klucz");
            }
            GetComponent<Renderer>().enabled = false;
        }
    }
}
