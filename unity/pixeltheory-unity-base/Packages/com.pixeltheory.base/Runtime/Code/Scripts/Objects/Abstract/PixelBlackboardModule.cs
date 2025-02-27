namespace Pixeltheory.Blackboard
{
    public abstract class PixelBlackboardModule : PixelObject
    {
        #region Methods
        #region Public
        public abstract void OnBlackboardLoad(PixelBlackboard blackboard);
        public abstract void OnBlackboardUnload(PixelBlackboard blackboard);
        #endregion //Public
        #endregion //Methods
    }
}