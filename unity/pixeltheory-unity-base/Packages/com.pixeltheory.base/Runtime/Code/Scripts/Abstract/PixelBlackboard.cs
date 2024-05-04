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
    [CreateAssetMenu(fileName ="PixelBlackboard", menuName = "Pixeltheory/Tests/Data/PixelBlackboard")]
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

        private void OnEnable()
        {
            /*
             *  Ellis 2023.12.22
             *  We can no longer use Application.IsPlaying to differentiate between non-play edit mode and play mode
             *  in the editor. OnEnable seems to be only called once, regardless of Editor mode, so the work around
             *  of using Application.IsPlaying is no longer needed, and actually does not work anymore.
             */
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

        private void OnDisable()
        {
            /*
             *  Ellis 2024.05.01
             *  Unfortunately, for OnDisable, we still have multiple calls on Editor Play mode, as the
             *  ScriptableObjects are unloaded on Edit mode then reloaded on Play mode. So we still need
             *  to still use Application.isPlaying to differentiate between Edit mode finished OnDisable
             *  and actual Play mode OnDisable.
             */
            if (Application.isPlaying && PixelBlackboard.sharedData != null)
            {
                PixelBlackboard.sharedData.OnBlackboardUnload();
                PixelBlackboard.sharedData = null;
            }
        }
        #endregion //Unity Messages
        #endregion //Methods
        #endregion //Instance
    }
}