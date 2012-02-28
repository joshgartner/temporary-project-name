using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Singleton class to have a handle on the player's attributes.
/// </summary>
public class playerAttributes : MonoBehaviour {
	#region Members
	private static playerAttributes instance;
	private string m_strName;
	private int m_nLevel;
	private int m_nHealth;
	private int m_nMana;
	private int m_nStrength;
	#endregion Members
	
	#region Constructor
	private playerAttributes() {}
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
				instance = new playerAttributes();
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
	#endregion Properties
	
	#region Game Events
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	#endregion User Events
}
