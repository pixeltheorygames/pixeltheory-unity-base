using System;
using System.Threading;
using log4net;
using Pixeltheory.Debug;
using UnityEditor;
using UnityEngine;
using Object = System.Object;


namespace Pixeltheory
{
    public class PixelObject : ScriptableObject
    {
        #region Fields
        #region Private
        private enum PixelObjectState
        {
            Asset,
            Object
        }
        [SerializeField] private PixelObjectState pixelObjectState = PixelObjectState.Asset;
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

        private void OnPlayModeStateChangedHandler(PlayModeStateChange playModeStateChange)
        {
            if (playModeStateChange == PlayModeStateChange.ExitingPlayMode)
            {
                EditorApplication.playModeStateChanged -= this.OnPlayModeStateChangedHandler;
                this.OnObjectDisable();
            }
        }
        
        #region PixelObject
        protected virtual void OnAssetEnable() { PixelLog.Log("OnAssetEnable"); }
        protected virtual void OnAssetDisable() { PixelLog.Log("OnAssetDisable"); }
        protected virtual void OnObjectEnable() { PixelLog.Log("OnObjectEnable"); }
        protected virtual void OnObjectDisable() { PixelLog.Log("OnObjectDisable"); }
        #endregion //PixelObject
        #endregion //Methods
    }   
}
