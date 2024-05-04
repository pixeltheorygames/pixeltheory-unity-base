namespace Pixeltheory.Blackboard
{
    public abstract class PixelBlackboardData : PixelObject, IPixelBlackboardData
    {
        #region Methods
        #region IPixelBlackboardData
        public abstract void OnBlackboardLoad();
        public abstract void OnBlackboardUnload();
        #endregion //IPixelBlackboardData
        #endregion //Methods
    }
}