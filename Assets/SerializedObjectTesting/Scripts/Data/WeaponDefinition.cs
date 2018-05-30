using System;
using UnityEngine;

namespace SerializedObjectTesting {

	// Weapon type enum.
	public enum WeaponType {
		Sword,
		Mace,
		Bow,
		Staff,
	}

	// Test weapon definition.
	[Serializable, CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon Definition")]
	public class WeaponDefinition : ScriptableObject {

		[SerializeField]
		public WeaponType weaponType;

		[SerializeField]
		public int damage;

		[SerializeField]
		public bool twoHanded;
	}
}