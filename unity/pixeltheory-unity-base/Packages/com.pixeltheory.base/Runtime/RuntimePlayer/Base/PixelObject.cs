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
        #endif

        private void OnEnable()
        {
            #if UNITY_EDITOR
            if (EditorApplication.isPlayingOrWillChangePlaymode)
            {
                EditorApplication.playModeStateChanged += this.OnPlayModeStateChangedHandler;   
            }
            #else
            this.OnObjectEnable();
            #endif
        }

        private void OnDisable()
        {
            #if UNITY_EDITOR
            if (EditorApplication.isPlayingOrWillChangePlaymode)
            {
                EditorApplication.playModeStateChanged -= this.OnPlayModeStateChangedHandler;   
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
            switch (playModeStateChange)
            {
                case PlayModeStateChange.ExitingEditMode:
                    this.OnObjectAwake();
                    break;
                case PlayModeStateChange.EnteredPlayMode:
                    this.OnObjectEnable();
                    break;
                case PlayModeStateChange.ExitingPlayMode:
                    this.OnObjectDisable();
                    break;
                case PlayModeStateChange.EnteredEditMode:
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
