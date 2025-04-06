using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
/*
 *	Ellis Note 2025.4.3
 * 
 *	ToDo - This needs to be changed to use UI Toolkit instead of IMGUI.
 * 
 */
namespace Pixeltheory.Editor
{
	[CustomPropertyDrawer(typeof(PixelKeyValuePair<,>))]
	public class PixelKeyValuePairDrawer : PropertyDrawer
	{

		#region Fields
		#region Private
		private const float ElementSpacing = 10f;
		#endregion //Private
		#endregion //Fields

		#region Methods
		#region Unity Messages
		public override void OnGUI(Rect rect, SerializedProperty property, GUIContent label)
		{
			Rect keyDisplayRect = new Rect(rect);
			Rect valueDisplayRect = new Rect(rect);
			keyDisplayRect.height = EditorGUIUtility.singleLineHeight;
			valueDisplayRect.height = EditorGUIUtility.singleLineHeight;
			keyDisplayRect.width *= 0.40f;
			valueDisplayRect.width *= 0.60f;
			valueDisplayRect.x += keyDisplayRect.width;
			keyDisplayRect.x += ElementSpacing / 2.0f;
			keyDisplayRect.width -= ElementSpacing;
			valueDisplayRect.x += ElementSpacing / 2.0f;
			valueDisplayRect.width -= ElementSpacing;
			SerializedProperty serializedKey = property.FindPropertyRelative("key");
			SerializedProperty serializedValue = property.FindPropertyRelative("value");
			EditorGUI.PropertyField(keyDisplayRect, serializedKey, GUIContent.none);
			EditorGUI.PropertyField(valueDisplayRect, serializedValue, GUIContent.none);
		}
		#endregion //Unity Messages

		#region Private
		/*
		 *	Ellis 2023.12.15
		 *	Use the following utility methods to extend the functionality of this property drawer
		 *	to be able to display nested objects in used as Keys and Values.
		 */
		private void DrawField(Rect rect, SerializedProperty property)
		{
			if (IsInline(property))
			{
				EditorGUI.PropertyField(rect, property, GUIContent.none);
			}
			else
			{
				rect.x += ElementSpacing / 2f;
				rect.width -= ElementSpacing;
		
				foreach (var child in IterateChildren(property))
				{
					EditorGUI.PropertyField(rect, child, false);
		
					rect.y += EditorGUIUtility.singleLineHeight + 2f;
				}
			}
		}
		
		private bool IsInline(SerializedProperty property)
		{
			switch (property.propertyType)
			{
				case SerializedPropertyType.Generic:
					return property.hasVisibleChildren == false;
			}
		
			return true;
		}
		
		private IEnumerable<SerializedProperty> IterateChildren(SerializedProperty property)
		{
			var path = property.propertyPath;
			property.Next(true);
			while (true)
			{
				yield return property;
		
				if (property.NextVisible(false) == false) break;
				if (property.propertyPath.StartsWith(path) == false) break;
			}
		}
		#endregion //Private
		#endregion //Methods
	}
} 