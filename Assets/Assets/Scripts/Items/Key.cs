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
            }
            GetComponent<Renderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
        }
    }
}


