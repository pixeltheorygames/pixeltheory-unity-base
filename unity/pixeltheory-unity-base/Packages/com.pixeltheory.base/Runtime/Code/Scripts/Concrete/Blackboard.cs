using System;
using UnityEngine;
using Object = UnityEngine.Object;


namespace Pixeltheory
{
    [Serializable]
    [CreateAssetMenu(menuName = "Pixeltheory/Architecture/Data/Blackboard")]
    public class Blackboard : PixelObject
    {
        #region Class
        #region Fields
        #region Private
        private static PixelObject sharedData;
        #endregion //Private
        #endregion //Fields
        #endregion //Class

        #region Instance
        #region Fields
        #region Inspector
        [SerializeField] private PixelObject data;
        #endregion //Inspector
        #endregion //Fields
        
        #region Properties
        #region Public
        public PixelObject Data
        {
            get
            {
                if (Blackboard.sharedData == null)
                {
                    Blackboard.sharedData = Object.Instantiate(this.data);
                    Blackboard.sharedData.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
                }
                return Blackboard.sharedData;
            }
        }
        #endregion //Public
        #endregion //Properties
        #endregion //Instance
    }
}