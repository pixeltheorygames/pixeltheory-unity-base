using UnityEngine;
using Pixeltheory.DataCache;
using Pixeltheory.Switchboard;
using Pixeltheory.WebGLUtilities;


namespace Pixeltheory.Blackboard
{ 
    [CreateAssetMenu(fileName = "PixelBlackboard", menuName = "Pixeltheory/Blackboard/PixelBlackboard")]
    public abstract class PixelBlackboard : PixelObject
    {
        #region Fields
        #region Private
        [SerializeField] private DataCacheModule dataCacheModule;
        [SerializeField] private Switchboard.SocketSwitchboardModule socketSwitchboard;
        [SerializeField] private WebGLUtilitiesModule webglUtilitiesModule;
        #endregion //Private
        #endregion //Fields

        #region Properties
        #region Public
        public DataCacheModule DataCache => this.dataCacheModule;
        public SocketSwitchboardModule Switchboard => this.socketSwitchboard;
        public WebGLUtilitiesModule WebGLUtilities => this.webglUtilitiesModule;
        #endregion //Public
        #endregion //Properties
    }
}
