using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
public class ReadOnlyPropertyDrawer : PropertyDrawer {

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUI.GetPropertyHeight(property, label, true);
    }

    override public void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        GUI.enabled = false;
        EditorGUI.PropertyField(position, property, label, true);
        GUI.enabled = true;
    }
}