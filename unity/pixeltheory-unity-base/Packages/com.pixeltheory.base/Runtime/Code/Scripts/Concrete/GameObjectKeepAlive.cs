using UnityEngine;
using Pixeltheory.Debug;


namespace Pixeltheory
{
    public class GameObjectKeepAlive : MonoBehaviour
    {
        #region Instance
        #region Methods
        #region Unity Messages
        protected virtual void Awake()
        {
            UnityEngine.Object.DontDestroyOnLoad(this.gameObject);
            PixelLog.Log
            (
                "[{0}] Setting as persistent through scene loads/unloads.",
                this.gameObject.name
            );
        }
        #endregion //Unity Messages
        #endregion //Methods
        #endregion //Instance
    }   
}