using UnityEngine;
using System.Collections;
using System;

public abstract class baseEnemy : MonoBehaviour {
	#region Members
	private string m_strName;
	private int m_nLevel;
	private int m_nHealth;
	private int m_nMana;
	private int m_nStrength;
	#endregion Members
	
	#region Properties
	protected abstract string Name { get; }
	protected abstract int Level { get; set; }
	protected abstract int Health { get; set; }
	protected abstract int Mana { get; set; }
	protected abstract int Strength { get; set; }
	#endregion Properties

	#region Methods
	protected virtual void meleeAttack() {}
	protected virtual void magicAttack() {}
	#endregion Methods
}
