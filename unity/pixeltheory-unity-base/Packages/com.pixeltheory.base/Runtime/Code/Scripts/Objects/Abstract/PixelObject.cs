#if UNITY_EDITOR
using UnityEditor;
#endif //UNITY_EDITOR
using UnityEngine;
using Pixeltheory.Debug;

namespace Pixeltheory
{
    public abstract class PixelObject : ScriptableObject
    {
        #region Fields
        #region Private
        private const string lifecycleLogFormat = "Method: {0}; Object Name: {1}; Instance ID: {2}";
        #endregion //Private
        #endregion //Fields
        
        #region Methods
        #region Unity Messages
        private void OnEnable()
        {
            #if UNITY_EDITOR
            if (EditorApplication.isPlayingOrWillChangePlaymode)
            {
                this.OnObjectEnable();
                EditorApplication.playModeStateChanged += this.OnPlayModeStateChangedHandler;
            }
            else
            {
                this.OnAssetEnable();
            }
            #else
            this.OnObjectEnable();
            #endif
        }

        private void OnDisable()
        {
            #if UNITY_EDITOR
            if (Application.isPlaying)
            {
                this.OnObjectDisable();
            }
            else
            {
                this.OnAssetDisable();
            }
            #else
            this.OnObjectDisable();
            #endif
        }
        #endregion //Unity Messages

        #if UNITY_EDITOR
        #region PlayModeStateChanged Event Handler
        private void OnPlayModeStateChangedHandler(PlayModeStateChange playModeStateChange)
        {
            if (playModeStateChange == PlayModeStateChange.ExitingPlayMode)
            {
                EditorApplication.playModeStateChanged -= this.OnPlayModeStateChangedHandler;
                this.OnObjectDisable();
            }
        }
        #endregion //PlayModeStateChanged Event Handler
        #endif //UNITY_EDITOR
        
        #region PixelObject Virtual Methods
        #if UNITY_EDITOR
        protected virtual void OnAssetEnable()
        {
            PixelLog.Log(PixelObject.lifecycleLogFormat, "OnAssetEnable", this.name, this.GetInstanceID());
        }
        protected virtual void OnAssetDisable()
        {
            PixelLog.Log(PixelObject.lifecycleLogFormat, "OnAssetDisable", this.name, this.GetInstanceID());
        }
        #endif //UNITY_EDITOR
        protected virtual void OnObjectEnable()
        {
            PixelLog.Log(PixelObject.lifecycleLogFormat, "OnObjectEnable", this.name, this.GetInstanceID());
        }
        protected virtual void OnObjectDisable()
        {
            PixelLog.Log(PixelObject.lifecycleLogFormat, "OnObjectDisable", this.name, this.GetInstanceID());
        }
        #endregion //PixelObject Virtual Methods
        #endregion //Methods
    }   
}
