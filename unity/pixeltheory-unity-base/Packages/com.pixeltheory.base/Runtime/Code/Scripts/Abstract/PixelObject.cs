using System;
using UnityEngine;


namespace Pixeltheory
{
    [Serializable]
    public abstract class PixelObject : ScriptableObject 
    {
        #region Fields
        #region Protected
        protected enum PixelObjectState
        {
            Disabled,
            Enabled
        }
        protected PixelObjectState currentPixelObjectState;
        #endregion //Proteced
        #endregion //Fields
    }   
}
