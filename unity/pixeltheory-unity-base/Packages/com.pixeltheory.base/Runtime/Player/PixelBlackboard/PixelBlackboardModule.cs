using System;
using NUnit.Framework.Constraints;


namespace Pixeltheory.Blackboard
{
    public abstract class PixelBlackboardModule : PixelObject
    {
        #region Instance
        #region Properties
        #region Public
        public abstract string ModuleKey { get; }
        #endregion //Public
        #endregion //Properties
        #endregion //Instance
    }
    
    [Serializable]
    public abstract class PixelBlackboardModule<T> : PixelBlackboardModule
    {
        #region Class
        #region Fields
        #region Private
        private static bool RuntimeInstantiationDisabled = false;
        #endregion //Private
        #endregion //Fields
        #endregion //Class

        #region Instance
        #region Methods
        #region PixelObject Overrides
        protected override void OnObjectAwake()
        {
            if (PixelBlackboardModule<T>.RuntimeInstantiationDisabled)
            {
                UnityEngine.Object.Destroy(this);
                return;
            }
            PixelBlackboardModule<T>.RuntimeInstantiationDisabled = true;
            base.OnObjectAwake();
        }

        protected override void OnObjectEnable()
        {
            if (PixelBlackboardModule<T>.RuntimeInstantiationDisabled)
            {
                return;
            }
            base.OnObjectEnable();
        }
        #endregion //PixelObject Overrides
        #endregion //Methods
        #endregion //Instance
    }
}