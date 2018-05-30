using UnityEngine;

// Including the UnityEditor namespace will expose editor types to the script
// and it will prevent this script from being included in builds.
using UnityEditor;

// Static class with functions executed by menu items.
public static class MenuItemFunction {
	
	// Do something from the system menu.
	[MenuItem("View/Custom/Do Something")]
	public static void DoSystemMenuThing() {
		Debug.Log(System.DateTime.Now);
	}
}
