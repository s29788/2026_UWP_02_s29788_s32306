using Player;
namespace Items
{
    public class Coin : ItemBase
    {
        public override void OnCollected(PlayerReferences playerReferences)
        {
            if (playerReferences != null)
            {
              playerReferences.GetInventory().AddCoins(1);
            }
            Destroy(gameObject);
        }
    }
}