using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Singleton class to have a handle on the player's attributes.
/// </summary>
public class playerAttributes : MonoBehaviour {
	#region Members
	private static playerAttributes instance;
	public string playerName;
	public string m_strName;
	public int m_nLevel;
	public int m_nExperience;
	public int m_nHealth;
	public int m_nMana;
	public int m_nStrength;
	public int m_nBagSpace;
	#endregion Members
	
	#region Constructor
	//private playerAttributes() {	
	//}
	
	#endregion Constructor
	
	#region Properties
	/// <summary>
	/// Singleton of player attributes
	/// </summary>
	/// <value>
	/// The instance.
	/// </value>
	public static playerAttributes Instance {
		get {
			if (instance == null) {
				GameObject go = new GameObject();
				instance = go.AddComponent<playerAttributes>();
				go.name = "instance";
				//instance.gameObject.AddComponent<playerAttributes>();
				//instance = new playerAttributes();
			}
			
			return instance;
		}
	}
	
	/// <summary>
	/// Gets or sets the name.
	/// </summary>
	/// <value>
	/// The name.
	/// </value>
	public string Name {
		get { return m_strName; }
		set { m_strName = value; }
	}
	
	/// <summary>
	/// Gets or sets the health.
	/// </summary>
	/// <value>
	/// The health.
	/// </value>
	public int Health {
		get { return m_nHealth; }
		set { m_nHealth = value; }
	}
	
	/// <summary>
	/// Gets or sets the mana.
	/// </summary>
	/// <value>
	/// The mana.
	/// </value>
	public int Mana {
		get { return m_nMana; }
		set { m_nMana = value; }
	}
	
	/// <summary>
	/// Gets or sets the strength.
	/// </summary>
	/// <value>
	/// The strength.
	/// </value>
	public int Strength {
		get { return m_nStrength; }
		set { m_nStrength = value; }
	}
	
	/// <summary>
	/// Gets or sets the level of player.
	/// </summary>
	/// <value>
	/// The level.
	/// </value>
	public int Level {
		get { return m_nLevel; }
		set { m_nLevel = value; }
	}
	
	/// <summary>
	/// Gets or sets the experience.
	/// </summary>
	/// <value>
	/// The experience.
	/// </value>
	public int Experience {
		get { return m_nExperience; }
		set { m_nExperience = value; }
	}
	
	/// <summary>
	/// Gets or sets the bag space.
	/// </summary>
	/// <value>
	/// The bag space.
	/// </value>
	public int BagSpace {
		get { return m_nBagSpace; }
		set { m_nBagSpace = value; }
	}
	#endregion Properties
	
	#region Game Events
	// Use this for initialization
	void Start () {
		m_nHealth = 100;
		m_nExperience = 1;
		m_nLevel = 1;
	}
	
	// Update is called once per frame
//	void Update () {
	
//	}
	
	#endregion User Events
}
