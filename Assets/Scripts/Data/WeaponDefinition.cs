using UnityEngine;

// Enumeration for a class of weapon.
public enum WeaponType {
	Sword,
	Axe,
	Bow,
}

// Data class that defines a weapon in our game.
// Stored as a ScriptableObject in our assets folder.
public class WeaponDefinition : ScriptableObject {

	// The amount of damage this weapon deals.
	public int damage;

	// The class this weapon.
	public WeaponType weaponType;

	// If true, this weapon takes two hands to weild.
	public bool isTwoHanded;
}
