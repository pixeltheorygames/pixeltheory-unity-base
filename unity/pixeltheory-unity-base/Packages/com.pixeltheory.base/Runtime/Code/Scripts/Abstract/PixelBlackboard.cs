using System;
using UnityEngine;


namespace Pixeltheory
{
    [Serializable]
    public abstract class PixelBlackboard<TypeSelf> : PixelObject where TypeSelf : PixelObject
    {
        #region Class
        #region Fields
        #region Private
        private static TypeSelf sharedData;
        #endregion //Private
        #endregion //Fields

        #region Properties
        #region Public
        public static TypeSelf SharedInstance => PixelBlackboard<TypeSelf>.sharedData;
        #endregion //Public
        #endregion //Properties
        #endregion //Class

        #region Instance
        #region Methods
        #region Unity Messages
        public void OnEnable()
        {
            // This asset should only lives in unmanaged memory, so OnEnable
            // is called when this asset is first loaded into unmanaged memory.
            if (PixelBlackboard<TypeSelf>.sharedData == null)
            {
                this.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
                PixelBlackboard<TypeSelf>.sharedData = this as TypeSelf;
            }
            else
            {
                this.hideFlags = HideFlags.None;
                Resources.UnloadAsset(this); //We have to unload instead of destroying because this is an asset.
            }
        }
        #endregion //Unity Messages
        #endregion //Methods
        #endregion //Instance
    }
}