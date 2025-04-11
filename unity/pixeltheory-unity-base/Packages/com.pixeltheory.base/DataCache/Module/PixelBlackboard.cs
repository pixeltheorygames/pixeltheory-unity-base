using UnityEngine;
using Pixeltheory.DataCache;


namespace Pixeltheory.Blackboard
{ 
    public partial class PixelBlackboard
    {
        #region Fields
        #region Private
        [SerializeField] private DataCacheModule dataCacheModule;
        #endregion //Private
        #endregion //Fields

        #region Properties
        #region Public
        public DataCacheModule DataCache => this.dataCacheModule;
        #endregion //Public
        #endregion //Properties
    }
}
