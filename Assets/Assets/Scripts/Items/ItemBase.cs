using Player;
using UnityEngine;
namespace Items
{
    public abstract class ItemBase : MonoBehaviour, IInteractable
    {
        public abstract void OnCollected(PlayerReferences playerReferences);
    }
}