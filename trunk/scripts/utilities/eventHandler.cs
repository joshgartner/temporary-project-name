using UnityEngine;
using System.Collections;

public class eventHandler : MonoBehaviour {
	
	public delegate void EventHandler(GameObject e);
	
	/// <summary>
	/// Occurs when enemey killed by the player.
	/// </summary>
	public event EventHandler enemyKilled;
	void OnEnemyKilled () {
    if (enemyKilled != null)
        enemyKilled (this.gameObject);
	}
	
	/// <summary>
	/// Occurs when an enemey spots the player.
	/// </summary>
	public event EventHandler playerSpotted;	
	void OnPlayerSpotted () {
    if (playerSpotted != null)
        playerSpotted (this.gameObject);
	}
}
