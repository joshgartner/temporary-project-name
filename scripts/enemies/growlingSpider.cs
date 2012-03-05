using UnityEngine;
using System.Collections;

public class growlingSpider : baseEnemy {
	
	public int m_nHealth;
	public int m_nLevel;
	
	public override string Name {
		get {
			return "Growling Spider";
		}
	}
	
	public override int Level {
		get {
			return m_nLevel;
		}
		set {
			m_nLevel = value;
		}
	}
	
	public override int Health {
		get {
			return m_nHealth;
		}
		set {
			m_nHealth = value;
		}			

	}
	
	public override int Mana {
		get {
			throw new System.NotImplementedException ();
		}
		set {
			throw new System.NotImplementedException ();
		}
	}
	
	public override int Strength {
		get {
			throw new System.NotImplementedException ();
		}
		set {
			throw new System.NotImplementedException ();
		}
	} 
	
	protected override void meleeAttack(){
		base.meleeAttack ();
	}

	protected override void magicAttack(){
		base.magicAttack ();
	}
	
	// Use this for initialization
	void Start () {
		Health = 100;
		Level = 1;
	}
	
	// Update is called once per frame
	
	//void OnCollisionEnter(Collision collision) {
	//	if (collision.collider.tag == "Player") {
	//		if (this.m_nHealth <= 0){
	//			Destroy(this.gameObject);
	//		}
	//		m_nHealth -= 100;
			//transform.Translate(0,15,0,Space.World);
	//	}
	//}
	
	//void OnTriggerEnter(Collider other) {
		
    //}
	
}
