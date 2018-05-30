using System;
using UnityEngine;

namespace SerializedObjectTesting {

	// Test character definition.
	[Serializable, CreateAssetMenu(fileName = "New Character", menuName = "Character Definition")]
	public class CharacterDefinition : ScriptableObject {
		public int level;
		public WeaponDefinition weapon;
		public int health;
	}
}
