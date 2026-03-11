using System.Collections.Generic;
using UnityEngine;

namespace Items
{
    public class Inventory : MonoBehaviour
    {
        private int _coins = 0;
        private List<Key> _keys = new List<Key>();
        
        public int GetCoinCount() => _coins;

        public void AddCoins(int amount)
        {
            _coins += amount;
        }
        public void AddKey(Key key){_keys.Add(key);}
        public void RemoveKey(Key key){_keys.Remove(key);}
        public List<Key> GetKeys() => _keys;
    }
}