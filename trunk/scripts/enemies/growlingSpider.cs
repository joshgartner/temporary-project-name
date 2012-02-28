using UnityEngine;
using System.Collections;

public class growlingSpider : baseEnemy {
	
	protected override string Name {
		get {
			return "Growling Spider";
		}
	}
	
	protected override int Level {
		get {
			throw new System.NotImplementedException ();
		}
		set {
			throw new System.NotImplementedException ();
		}
	}
	
	protected override int Health {
		get {
			throw new System.NotImplementedException ();
		}
		set {
			throw new System.NotImplementedException ();
		}
	}
	
	protected override int Mana {
		get {
			throw new System.NotImplementedException ();
		}
		set {
			throw new System.NotImplementedException ();
		}
	}
	
	protected override int Strength {
		get {
			throw new System.NotImplementedException ();
		}
		set {
			throw new System.NotImplementedException ();
		}
	} 
	
	protected override void meleeAttack ()
	{
		base.meleeAttack ();
	}

	protected override void magicAttack ()
	{
		base.magicAttack ();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
