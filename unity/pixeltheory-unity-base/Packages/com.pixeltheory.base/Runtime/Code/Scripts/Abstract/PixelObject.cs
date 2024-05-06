using System;
using UnityEditor;
using UnityEngine;


namespace Pixeltheory
{
    [Serializable]
    public abstract class PixelObject : ScriptableObject 
    {
        #region Methods
        #region Unity Messages
        protected virtual void OnEnable()
        {
	        #if UNITY_EDITOR
	        EditorApplication.playModeStateChanged += this.OnEditorPlayModeChanged;
	        #else
			this.OnPlay();
	        #endif
        }

        protected virtual void OnDisable()
        {
	        #if UNITY_EDITOR
	        EditorApplication.playModeStateChanged -= this.OnEditorPlayModeChanged;
	        #else
			this.OnStop();
	        #endif
        }
        #endregion //Unity Messages

        #region Protected
        #if UNITY_EDITOR
        protected virtual void OnEditorPlayModeChanged(PlayModeStateChange playModeStateChange)
        {
	        switch (playModeStateChange)
	        {
		        case PlayModeStateChange.ExitingEditMode:
			        this.OnPlay();
			        break;
		        case PlayModeStateChange.ExitingPlayMode:
			        this.OnStop();
			        break;
		        case PlayModeStateChange.EnteredEditMode:
		        case PlayModeStateChange.EnteredPlayMode:
		        default:
			        //NOP
			        break;
	        }
        }
        #endif
        protected virtual void OnPlay() { }
        protected virtual void OnStop() { }
        #endregion //Protected
        #endregion //Methods
    }   
}
