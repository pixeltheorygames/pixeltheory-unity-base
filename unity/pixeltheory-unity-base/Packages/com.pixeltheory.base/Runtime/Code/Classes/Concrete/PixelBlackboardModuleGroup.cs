using System;
using System.Collections.Generic;
using Pixeltheory.Attributes;
using UnityEngine;
using UnityEngine.Serialization;
#if UNITY_EDITOR
using UnityEditor;
#endif //UNITY_EDITOR


namespace Pixeltheory.Blackboard
{
	[Serializable]
	public class PixelBlackboardModuleGroup
	{
		#region Fields
		#if UNITY_EDITOR
		[SerializeField] private SceneAsset sceneAsset;
		[ShowOnlyInInspector]
		#endif //UNITY_EDITOR
		[SerializeField] private string sceneName;
		[SerializeField] private List<PixelBlackboardModule> modules;
		#endregion //Fields

		#region Properties
		#region Public
		public string SceneName => this.sceneName;
		public List<PixelBlackboardModule> Modules => this.modules;
		#endregion //Public
		#endregion //Properties
		
		#if UNITY_EDITOR
		#region Methods
		#region Public
		public void SetSceneName()
		{
			if (this.sceneAsset != null)
			{
				this.sceneName = this.sceneAsset.name;
			}
		}
		#endregion //Public
		#endregion //Methods
		#endif     //UNITY_EDITOR
	}
}