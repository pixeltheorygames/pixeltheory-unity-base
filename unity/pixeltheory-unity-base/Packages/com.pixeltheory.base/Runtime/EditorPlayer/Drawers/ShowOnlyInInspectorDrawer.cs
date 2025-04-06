using UnityEditor;
using UnityEngine;
using Pixeltheory.Attributes;
/*
 *	Ellis Note 2025.4.3
 *
 *	ToDo - This needs to be changed to use UI Toolkit instead of IMGUI.
 *
 */
namespace Pixeltheory.Editor
{
	[CustomPropertyDrawer(typeof(ShowOnlyInInspectorAttribute))]
	public class ShowOnlyInInspectorDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty prop, GUIContent label)
		{
			string valueStr;
			switch (prop.propertyType)
			{
				case SerializedPropertyType.Integer:
					valueStr = prop.intValue.ToString();
					break;
				case SerializedPropertyType.Boolean:
					valueStr = prop.boolValue.ToString();
					break;
				case SerializedPropertyType.Float:
					valueStr = prop.floatValue.ToString("0.00000");
					break;
				case SerializedPropertyType.String:
					valueStr = prop.stringValue;
					break;
				default:
					valueStr = "(not supported)";
					break;
			}
			EditorGUI.LabelField(position, label.text, valueStr);
		}
	}
}