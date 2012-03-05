using UnityEngine;
using System.Collections;
using System;

public abstract class baseEnemy : MonoBehaviour {

	#region Properties
	public abstract string Name { get; }
	public abstract int Level { get; set; }
	public abstract int Health { get; set; }
	public abstract int Mana { get; set; }
	public abstract int Strength { get; set; }
	#endregion Properties

	#region Methods
	protected virtual void meleeAttack() {}
	protected virtual void magicAttack() {}
	#endregion Methods
	
	public void DestroyEnemey() {
		// enable falling animation
		// allow enemey to be lootable. 
		// set timer to make enemey disappear. 
	}
	
	void Update() {
		if (this.Health <= 0) {	// Enemey died. 
			//Debug.Log(playerAttributes.Instance.Experience);
			playerAttributes.Instance.Experience += 10;
			Debug.Log(playerAttributes.Instance.Experience);
			// TODO: Implement DestroyEnemey();
			Destroy(this.gameObject);
		}
	}
	
	void OnCollisionEnter(Collision collision) {
		if (collision.collider.tag == "Player") {
			this.Health -= 100;
		}
	}
}
