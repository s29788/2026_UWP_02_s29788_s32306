using UnityEngine;
using System; 
namespace Player
{
    [Serializable] 
    public class PlayerData : MonoBehaviour
    {
        [SerializeField] private int score;
        [SerializeField] private int hp;

        public int GetScore() => score;
        public void SetScore(int newScore) => score = newScore;

        public int GetHp() => hp;
        public void SetHp(int newHp) => hp = newHp;

        public void AddScore(int amount) => score += amount;
        public void AddHp(int amount) => hp += amount;
        public void SubtractHp(int amount) => hp -= amount;
    }
}