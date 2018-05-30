using UnityEngine;
using UnityEditor;

// Inspector for CharacterDefinitions.
[CustomEditor(typeof(CharacterDefinition))]
public class CharacterDefinitionInspector : Editor {

	// Render the inspector view.
	public override void OnInspectorGUI() {
		base.OnInspectorGUI();

		var characterDefinition = target as CharacterDefinition;

		GUIStyle labelStyle = GUI.skin.label;
		labelStyle.fontStyle = FontStyle.Bold;

		string totalDamageLabelText = string.Format("Total Damage: {0}", characterDefinition.GetTotalDamage());
		EditorGUILayout.LabelField(totalDamageLabelText, labelStyle);
	}
}
