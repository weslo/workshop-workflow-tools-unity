using UnityEngine;

// Enumeration for a race of character.
public enum CharacterRace {
	Human,
	Elf,
	Dwarf,
	Halfling,
}

// Enumeration for character classes.
public enum CharacterClass {
	Fighter,
	Wizard,
	Rogue,
	Ranger,
}

// Data class that defines a character in our game.
// Stored as a ScriptableObject in our assets folder.
[CreateAssetMenu(fileName = "New Character", menuName = "Custom/Character Definition")]
public class CharacterDefinition : ScriptableObject {
	
	// The maximum level a character can be.
	public const int LEVEL_CAP = 20;

	// This character's level.
	[Range(1, 20)]
	public int level;

	// This character's race.
	public CharacterRace race;

	// This character's class.
	public CharacterClass combatClass;

	// The weapon this character wields.
	private WeaponDefinition weapon;
}
