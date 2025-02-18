using System;
using System.Collections.Generic;
using Pixeltheory.Debug;
#if UNITY_EDITOR
using UnityEditor;
#endif //UNITY_EDITOR
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Pixeltheory.Blackboard
{
    [Serializable]
    [CreateAssetMenu(fileName ="PixelBlackboard", menuName = "Pixeltheory/Data/PixelBlackboard")]
    public class PixelBlackboard : PixelObject
    {
        #region Class
        #region Fields
        #region Private
        private static PixelBlackboardData sharedData;
        #endregion //Private
        #endregion //Fields
        #endregion Class

        #region Instance
        #region Fields
        #region Inspector
        [SerializeField] private PixelBlackboardData defaultData;
        [SerializeField] private List<PixelKeyValuePair<string,PixelBlackboardData>> sceneNameToDataList;
        #endregion //Inspector
        #endregion //Fields
        
        #region Properties
        #region Public
        public PixelBlackboardData Data => PixelBlackboard.sharedData;
        #endregion //Public
        #endregion //Properties
        
        #region Methods
        #region PixelObject
        // protected void OnEnable()
        // {
        //     if (base.currentPixelObjectState == PixelObjectState.Disabled)
        //     {
        //         base.currentPixelObjectState = PixelObjectState.Enabled;
        //         if (PixelBlackboard.sharedData == null) { PixelBlackboard.sharedData = this.LoadBlackboardData(); }
        //     }
        // }
        //
        // protected void OnDisable()
        // {
        //     if (base.currentPixelObjectState == PixelObjectState.Enabled)
        //     {
        //         if (PixelBlackboard.sharedData != null) { this.UnloadBlackboardData(); }
        //         base.currentPixelObjectState = PixelObjectState.Disabled;
        //     }
        // }
        #endregion //PixelObject
        
        #region Protected
        protected PixelBlackboardData LoadBlackboardData()
        {
            if (this.defaultData == null)
            {
                PixelLog.Error("[PixelBlackboard.LoadBlackboardData] No default data found!");
                return null;
            }
            PixelBlackboardData dataToClone = this.defaultData;
            if (this.sceneNameToDataList != null && this.sceneNameToDataList.Count > 0)
            {
                string sceneName = SceneManager.GetActiveScene().name;
                foreach (PixelKeyValuePair<string, PixelBlackboardData> kvPair in this.sceneNameToDataList)
                {
                    if (sceneName == kvPair.Key)
                    {
                        dataToClone = kvPair.Value;
                        break;
                    }
                }   
            }
            PixelBlackboard.sharedData = PixelBlackboardData.Instantiate(dataToClone);
            PixelBlackboard.sharedData.OnBlackboardLoad();
            return PixelBlackboard.sharedData;
        }

        protected void UnloadBlackboardData()
        {
            PixelBlackboard.sharedData.OnBlackboardUnload();
            PixelBlackboard.sharedData = null;   
        }
        #endregion //Protected 
        #endregion //Methods
        #endregion //Instance
    }
}