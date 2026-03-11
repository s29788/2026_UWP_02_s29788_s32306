using UnityEngine;

namespace Enemy
{
    [CreateAssetMenu(menuName = "Enemy/New Enemy")]
    public class EnemySO : ScriptableObject
    {
        public string enemyName;
        public int damage;
    }
}