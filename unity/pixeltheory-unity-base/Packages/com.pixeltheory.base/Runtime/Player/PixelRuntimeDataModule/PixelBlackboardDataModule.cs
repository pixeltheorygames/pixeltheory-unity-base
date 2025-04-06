using UnityEngine;


namespace Pixeltheory.Blackboard
{
    public partial class PixelBlackboard
    {
        #region Fields
        #region Private
        private PixelRuntimeDataModule pixelRuntimeDataModule;
        #endregion //Private
        #endregion //Fields

        #region Properties
        #region Public
        public PixelRuntimeDataModule RuntimeDataModule => this.pixelRuntimeDataModule ?? this.GetBlackboardModule<PixelRuntimeDataModule>(PixelRuntimeDataModule.moduleKey);
        #endregion //Public
        #endregion //Properties
    }
}