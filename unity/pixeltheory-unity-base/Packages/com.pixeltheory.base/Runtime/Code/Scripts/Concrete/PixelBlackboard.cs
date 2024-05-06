using System;
using System.Collections.Generic;
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
        
        #if UNITY_EDITOR
        [SerializeField] private List<PixelKeyValuePair<SceneAsset, PixelBlackboardData>> sceneToDataList;
        #endif //UNITY_EDITOR
        
        #endregion //Inspector

        #region Private
        [SerializeField, HideInInspector] private List<PixelKeyValuePair<string, PixelBlackboardData>> sceneNameToDataList;
        #endregion //Private
        #endregion //Fields
        
        #region Properties
        #region Public
        public PixelBlackboardData Data => PixelBlackboard.sharedData;
        #endregion //Public
        #endregion //Properties
        
        #region Methods
        #region Unity Messages
        #if UNITY_EDITOR
        private void OnValidate()
        {
            this.sceneNameToDataList.Clear();
            foreach (PixelKeyValuePair<SceneAsset, PixelBlackboardData> kvPair  in this.sceneToDataList)
            {
                SceneAsset sceneAsset = kvPair.Key as SceneAsset;
                PixelKeyValuePair<string, PixelBlackboardData> translatedKVPair =
                    new PixelKeyValuePair<string, PixelBlackboardData>(sceneAsset.name, kvPair.Value);
                this.sceneNameToDataList.Add(translatedKVPair);
            }
        }
        #endif //Unity_Editor
        #endregion //Unity Messages

        #region PixelObject
        protected override void OnPlay()
        {
            if (PixelBlackboard.sharedData == null)
            {
                string sceneName = SceneManager.GetActiveScene().name;
                PixelBlackboardData dataToClone = this.defaultData;
                foreach (PixelKeyValuePair<string, PixelBlackboardData> kvPair in this.sceneNameToDataList)
                {
                    if (sceneName == kvPair.Key)
                    {
                        dataToClone = kvPair.Value;
                        break;
                    }
                }
                PixelBlackboard.sharedData = PixelBlackboardData.Instantiate(dataToClone);
                PixelBlackboard.sharedData.OnBlackboardLoad();   
            }
        }

        protected override void OnStop()
        {
            if (PixelBlackboard.sharedData != null)
            {
                PixelBlackboard.sharedData.OnBlackboardUnload();
                PixelBlackboard.sharedData = null;
            }
        }
        #endregion //PixelObject
        #endregion //Methods
        #endregion //Instance
    }
}