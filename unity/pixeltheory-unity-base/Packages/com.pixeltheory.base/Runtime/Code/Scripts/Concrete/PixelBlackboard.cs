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
        public PixelBlackboardData Data
        {
            get
            {
                #if UNITY_EDITOR
                /*
                 * Ellis 2024.05.04
                 * In the Editor, we have to lazy instantiate the blackboard data
                 * as there is no (reliable) way to know when the Play button has
                 * just been pressed.
                 */
                if (PixelBlackboard.sharedData == null)
                {
                    this.LoadBlackboardData();
                }
                #endif //UNITY_EDITOR
                return PixelBlackboard.sharedData;
            }
        }
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
        
        protected void OnEnable()
        {
            #if UNITY_EDITOR
            EditorApplication.playModeStateChanged += this.OnEditorPlayModeStateChange;
            #else //UNITY_EDITOR
            if (PixelBlackboard.sharedData == null)
            {
                this.LoadBlackboardData();
            }
            #endif ///!UNITY_EDITOR
        }
        
        protected void OnDisable()
        {
            #if UNITY_EDITOR
            EditorApplication.playModeStateChanged -= this.OnEditorPlayModeStateChange;
            #else //UNITY_EDITOR
            if (PixelBlackboard.sharedData != null)
            {
                this.UnloadBlackboardData();   
            }
            #endif //!UNITY_EDITOR
        }
        #endregion //Unity Messages

        #region Protected
        #if UNITY_EDITOR
        protected void OnEditorPlayModeStateChange(PlayModeStateChange playModeStateChange)
        {
            if (playModeStateChange == PlayModeStateChange.ExitingPlayMode)
            {
                if (PixelBlackboard.sharedData != null)
                {
                    this.UnloadBlackboardData();   
                }
            }
        }
        #endif //UNITY_EDITOR

        protected void LoadBlackboardData()
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