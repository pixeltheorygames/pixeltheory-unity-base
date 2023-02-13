namespace Pixeltheory
{
    public interface IPoolable
    {
        public void Set(params object[] args);
        public void Reset();
    }
}