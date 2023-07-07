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
        #endregion //Class

        #region Instance
        #region Properties
        #region Public
        public TypeSelf SharedInstance
        {
            get
            {
                if (PixelBlackboard<TypeSelf>.sharedData == null)
                {
                    this.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
                    PixelBlackboard<TypeSelf>.sharedData = this as TypeSelf;
                }
                else
                {
                    this.hideFlags = HideFlags.None;
                    Resources.UnloadAsset(this); //We have unload instead of destroying because this is an asset.
                }
                return PixelBlackboard<TypeSelf>.sharedData;
            }
        }
        #endregion //Public
        #endregion //Properties
        #endregion //Instance
    }
}