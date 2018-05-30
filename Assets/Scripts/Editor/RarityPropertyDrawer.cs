using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// Custom property drawer for Rarity fields.
[CustomPropertyDrawer(typeof(Rarity))]
public class RarityPropertyDrawer : PropertyDrawer {

	// Dictionary of rarities to associated colors.
	public static readonly Dictionary<Rarity, Color> RARITY_COLORS = new Dictionary<Rarity, Color> {
		{ Rarity.Trash, Color.grey },
		{ Rarity.Common, Color.white },
		{ Rarity.Uncommon, Color.green },
		{ Rarity.Rare, Color.cyan },
		{ Rarity.Epic, Color.magenta },
		{ Rarity.Legendary, Color.yellow },
	};

	// Render this property in a GUI context.
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
		
		Rarity current = (Rarity)property.enumValueIndex;
		Debug.Log(property.enumValueIndex);
		Rarity[] rarities = System.Enum.GetValues(typeof(Rarity)) as Rarity[];

		float btnWidth = position.width / rarities.Length;

		for(int i = 0; i < rarities.Length; i++) {
			Rarity rarity = rarities[i];

			Rect rect = EditorGUI.IndentedRect(position);
			rect.xMin += btnWidth * i;
			rect.width = btnWidth;

			Color prevGuiColor = GUI.color;

			GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
			buttonStyle.fontStyle = FontStyle.Bold;
			if(rarity == current) {
				GUI.color = RARITY_COLORS[rarity];
			}
			else {
				buttonStyle.normal.textColor = RARITY_COLORS[rarity];
			}

			string btnLabel = rarity.ToString().Substring(0, 1);
			if(GUI.Button(rect, btnLabel, buttonStyle)) {
				property.enumValueIndex = i;
			}

			GUI.color = prevGuiColor;
		}
	}

	// Return the height this property takes up.
	public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
		return base.GetPropertyHeight(property, label) * 2;
	}
}
