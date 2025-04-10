using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(EaseCurve))]
public class EaseCurveDrawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUI.GetPropertyHeight(GetTypeProperty(property), label, true);
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.PropertyField(position, GetTypeProperty(property), label, true);
    }

    private SerializedProperty GetTypeProperty(SerializedProperty property)
    {
        return property.FindPropertyRelative("m_Type");
    }
}
