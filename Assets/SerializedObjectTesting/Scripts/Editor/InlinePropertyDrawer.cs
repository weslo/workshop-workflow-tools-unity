using UnityEngine;
using UnityEditor;

namespace SerializedObjectTesting.Tools {

	// Override to render a property and its relative properties inline in the inspector.
	// This doesn't handle cases where the property doesn't target a Unity asset.
	public abstract class InlinePropertyDrawer : PropertyDrawer {

		// Cache the number of fields calculated in GetPropertyHeight.
		private int numFields;

		// Draw the the GUI layout.
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
			
			// Calculate the height of the rect that will draw fields.
			Rect rect = position;
			rect.height /= numFields;
			float fieldHeight = rect.height;
			
			// Create a serialized copy of the object this drawer targets.
			// This is where we assume the property drawer targets a Unity asset.
			SerializedObject obj = new SerializedObject(property.objectReferenceValue);

			// Add a field to replace the object as an asset.
			EditorGUI.ObjectField(rect, property, label);
			EditorGUI.indentLevel++;

			// Use the first property as an iterator to traverse all members.
			SerializedProperty prop = obj.GetIterator();
			if(prop.NextVisible(true)) {
				do {

					// Ignore the script field Unity generates.
					if(prop.name == "m_Script") {
						continue;
					}

					// Move the draw rect and yield to member's property drawer.
					rect.yMin += fieldHeight;
					rect.yMax += fieldHeight;
					EditorGUI.PropertyField(rect, prop);

				} while(prop.NextVisible(false));
			}

			// Apply any changes.
			obj.ApplyModifiedProperties();
		}

		// Get the height of this property.
		public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
			
			// Use iterator to count number of members each frame.
			// There might be a better way to do this to avoid a double pass on the members.
			SerializedObject obj = new SerializedObject(property.objectReferenceValue);
			SerializedProperty counter = obj.GetIterator();
			numFields = 0; // +1 for object field, -1 for skipped m_Script field.
			if(counter.NextVisible(true)) {
				do {
					numFields++;
				} while(counter.NextVisible(false));
			}

			// Use base property height as the height of a single field.
			return base.GetPropertyHeight(property, label) * numFields;
		}
	}
}