using UnityEngine;
namespace Player
{
	[CreateAssetMenu(menuName="Player/New Player")]
	public class PlayerSO : ScriptableObject
	{
	    public string playerName;
	    public int playerScore;
	}
}