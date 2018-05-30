using UnityEngine;

// Enumeration for a class of weapon.
public enum WeaponType {
	Sword,
	Axe,
	Bow,
}

// Enumeration for a generic rarity level.
public enum Rarity {
	Trash,
	Common,
	Uncommon,
	Rare,
	Epic,
	Legendary,
}

// Data class that defines a weapon in our game.
// Stored as a ScriptableObject in our assets folder.
[CreateAssetMenu(fileName = "New Weapon", menuName = "Custom/Weapon Definition")]
public class WeaponDefinition : ScriptableObject {

	// The amount of damage this weapon deals.
	public int damage;

	// The class this weapon.
	public WeaponType weaponType;

	// If true, this weapon takes two hands to weild.
	public bool isTwoHanded;

	// The rarity of this weapon.
	public Rarity rarity;
}
