using Player;
namespace Items
{
    public interface IInteractable
    {
        void OnCollected(PlayerReferences playerReferences);
    }
}

