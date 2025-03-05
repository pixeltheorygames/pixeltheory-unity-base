namespace Pixeltheory.Blackboard
{
    public abstract class PixelBlackboardModule : PixelObject
    {
        #region Properties
        #region Public
        public abstract string ModuleKey { get; }
        #endregion //Public
        #endregion //Properties
        
        #region Methods
        #region Public
        public abstract void OnBlackboardLoad(PixelBlackboard blackboard);
        public abstract void OnBlackboardUnload(PixelBlackboard blackboard);
        #endregion //Public
        #endregion //Methods
    }
}