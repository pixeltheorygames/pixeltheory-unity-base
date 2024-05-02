using System;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif //UNITY_EDITOR
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Pixeltheory
{
    [Serializable]
    public abstract class PixelBlackboard<TypeData> : PixelObject
        where TypeData : PixelObject
    {
        #region Class
        #region Fields
        #region Private
        private static TypeData sharedData;
        #endregion //Private
        #endregion //Fields
        #endregion Class

        #region Instance
        #region Fields
        #region Inspector
        [SerializeField] private TypeData defaultData;
        
        #if UNITY_EDITOR
        [SerializeField] private List<PixelKeyValuePair<SceneAsset, TypeData>> sceneToDataList;
        #endif //UNITY_EDITOR
        
        #endregion //Inspector

        #region Private
        [SerializeField, HideInInspector] private List<PixelKeyValuePair<string, TypeData>> sceneNameToDataList;
        #endregion //Private
        #endregion //Fields
        
        #region Properties
        #region Public
        public TypeData Data => PixelBlackboard<TypeData>.sharedData;
        #endregion //Public
        #endregion //Properties
        
        #region Methods
        #region Unity Messages
        #if UNITY_EDITOR
        private void OnValidate()
        {
            this.sceneNameToDataList.Clear();
            foreach (PixelKeyValuePair<SceneAsset, TypeData> kvPair  in this.sceneToDataList)
            {
                SceneAsset sceneAsset = kvPair.Key as SceneAsset;
                PixelKeyValuePair<string, TypeData> translatedKVPair =
                    new PixelKeyValuePair<string, TypeData>(sceneAsset.name, kvPair.Value);
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
            TypeData dataToClone = this.defaultData;
            foreach (PixelKeyValuePair<string, TypeData> kvPair in this.sceneNameToDataList)
            {
                if (sceneName == kvPair.Key)
                {
                    dataToClone = kvPair.Value;
                    break;
                }
            }
            PixelBlackboard<TypeData>.sharedData = PixelBlackboard<TypeData>.Instantiate(dataToClone);
        }
        #endregion //Unity Messages
        #endregion //Methods
        #endregion //Instance
    }
}