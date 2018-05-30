using UnityEngine;
using UnityEditor;

namespace SerializedObjectTesting.Tools {

	// Simple override to inline weapons in the inspector.
	[CustomPropertyDrawer(typeof(WeaponDefinition))]
	public class WeaponPropertyDrawer : InlinePropertyDrawer { }
}
