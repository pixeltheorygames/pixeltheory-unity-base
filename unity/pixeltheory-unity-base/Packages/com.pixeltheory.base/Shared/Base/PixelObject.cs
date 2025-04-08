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
        #if !UNITY_EDITOR
        private void Awake()
        {
            this.OnObjectAwake();
        }
        #endif //!UNITY_EDITOR
        
        
        private void OnEnable()
        {
            #if UNITY_EDITOR
            if (EditorApplication.isPlayingOrWillChangePlaymode)
            {
                this.OnObjectAwake();
                EditorApplication.playModeStateChanged += this.OnPlayModeStateChangedHandler;
            }
            #else //UNITY_EDITOR
            this.OnObjectEnable();
            #endif //!UNITY_EDITOR
        }
        
        private void OnDisable()
        {
            #if UNITY_EDITOR
            if (EditorApplication.isPlaying)
            {
                EditorApplication.playModeStateChanged -= this.OnPlayModeStateChangedHandler;
                this.OnObjectDisable();
            }
            #else //UNITY_EDITOR
            this.OnObjectDisable();
            #endif //!UNITY_EDITOR
        }
        #endregion //Unity Messages

        #if UNITY_EDITOR
        #region PlayModeStateChanged Event Handler
        private void OnPlayModeStateChangedHandler(PlayModeStateChange playModeStateChange)
        {
            switch (playModeStateChange)
            {
                case PlayModeStateChange.EnteredPlayMode:
                    this.OnObjectEnable();
                    break;
                case PlayModeStateChange.ExitingPlayMode:
                    EditorApplication.playModeStateChanged -= this.OnPlayModeStateChangedHandler;
                    this.OnObjectDisable();
                    break;
                default:
                    //NOP
                    break;
            }
        }
        #endregion //PlayModeStateChanged Event Handler
        #endif //UNITY_EDITOR
        
        #region PixelObject Virtual Methods
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
