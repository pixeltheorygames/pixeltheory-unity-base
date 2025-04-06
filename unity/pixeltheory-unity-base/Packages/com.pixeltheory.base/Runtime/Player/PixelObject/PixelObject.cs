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
        private const string lifecycleLogFormat = "Method: {0}; Object Name: {1}; Object Type: {2}; Instance ID: {3}";
        #endregion //Private
        #endregion //Fields
        
        #region Methods
        #region Unity Messages
        private void Awake()
        {
            #if UNITY_EDITOR
            if (EditorApplication.isPlayingOrWillChangePlaymode)
            {
                this.OnObjectAwake();
            }
            else
            {
                this.OnAssetAwake();
            }
            #else
            this.OnObjectAwake();
            #endif
        }

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
        protected virtual void OnAssetAwake()
        {
            PixelLog.Log(PixelObject.lifecycleLogFormat, "OnAssetAwake", this.name, this.GetType().Name, this.GetInstanceID());
        }
        
        protected virtual void OnAssetEnable()
        {
            PixelLog.Log(PixelObject.lifecycleLogFormat, "OnAssetEnable", this.name, this.GetType().Name, this.GetInstanceID());
        }
        
        protected virtual void OnAssetDisable()
        {
            PixelLog.Log(PixelObject.lifecycleLogFormat, "OnAssetDisable", this.name, this.GetType().Name, this.GetInstanceID());
        }
        #endif //UNITY_EDITOR
        protected virtual void OnObjectAwake()
        {
            PixelLog.Log(PixelObject.lifecycleLogFormat, "OnObjectAwake", this.name, this.GetType().Name, this.GetInstanceID());
        }
        
        protected virtual void OnObjectEnable()
        {
            PixelLog.Log(PixelObject.lifecycleLogFormat, "OnObjectEnable", this.name, this.GetType().Name, this.GetInstanceID());
        }
        
        protected virtual void OnObjectDisable()
        {
            PixelLog.Log(PixelObject.lifecycleLogFormat, "OnObjectDisable", this.name, this.GetType().Name, this.GetInstanceID());
        }
        #endregion //PixelObject Virtual Methods
        #endregion //Methods
    }   
}
