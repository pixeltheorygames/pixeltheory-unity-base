using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Pixeltheory.Blackboard
{
    [CreateAssetMenu(fileName = "PixelBlackboard", menuName = "Pixeltheory/Blackboard/PixelBlackboard", order = 0)]
    public class PixelBlackboard : PixelObject
    {
        #region Fields
        #region Inspector
        [SerializeField] private List<PixelBlackboardModuleGroup> blackboardModuleGroupList;
        #endregion //Inspector

        #region Private
        [NonSerialized] private List<PixelBlackboardModule> builtInBlackboardModuleList;
        [NonSerialized] private List<PixelBlackboardModule> userBlackboardModuleList;
        [NonSerialized] private Dictionary<string, PixelBlackboardModule> blackboardModuleDictionary;
        #endregion //Private
        #endregion //Fields
        
        #region Methods
        #if UNITY_EDITOR
        #region Unity Messages
        private void OnValidate()
        {
            foreach (PixelBlackboardModuleGroup blackboardModuleGroup in this.blackboardModuleGroupList)
            {
                blackboardModuleGroup.SetSceneName();
            }
        }
        #endregion //Unity Messages
        #endif //UNITY_EDITOR
        
        #region PixelObject Overrides
        protected override void OnObjectEnable()
        {
            this.OnBlackboardLoad(this);
        }

        protected override void OnObjectDisable()
        {
            this.OnBlackboardUnload(this);
        }
        #endregion //PixelObject Overrides

        #region Private
        private void OnBlackboardLoad(PixelBlackboard blackboard)
        {
            this.builtInBlackboardModuleList = new List<PixelBlackboardModule>();
            this.userBlackboardModuleList = new List<PixelBlackboardModule>();
            this.blackboardModuleDictionary = new Dictionary<string, PixelBlackboardModule>();
            this.InitBuiltInModules();
            this.InitUserModules();
        }

        private void OnBlackboardUnload(PixelBlackboard blackboard)
        {
            this.DeinitAllModules();
            this.blackboardModuleDictionary.Clear();
            this.blackboardModuleDictionary = null;
            this.userBlackboardModuleList.Clear();
            this.userBlackboardModuleList = null;
            this.builtInBlackboardModuleList.Clear();
            this.builtInBlackboardModuleList = null;
        }

        private void InitBuiltInModules()
        {
            PixelBlackboardModuleRuntimeData builtInModuleRuntimeData = PixelObject.CreateInstance<PixelBlackboardModuleRuntimeData>();
            builtInModuleRuntimeData.OnBlackboardLoad(this);
            this.builtInBlackboardModuleList.Add(builtInModuleRuntimeData);
            this.blackboardModuleDictionary.Add(builtInModuleRuntimeData.ModuleKey, builtInModuleRuntimeData);
        }

        private void InitUserModules()
        {
            if (this.blackboardModuleGroupList.Count > 0)
            {
                this.userBlackboardModuleList = this.blackboardModuleGroupList[0].Modules;
                foreach (PixelBlackboardModuleGroup sceneAndDataListPair in this.blackboardModuleGroupList)
                {
                    if (sceneAndDataListPair.SceneName == SceneManager.GetActiveScene().name)
                    {
                        this.userBlackboardModuleList = sceneAndDataListPair.Modules;
                    }
                }
                for (int i = 0; i < this.userBlackboardModuleList.Count; i++)
                {
                    this.userBlackboardModuleList[i].OnBlackboardLoad(this);
                    this.blackboardModuleDictionary.Add
                        (this.userBlackboardModuleList[i].ModuleKey, this.userBlackboardModuleList[i]);
                }   
            }
        }

        private void DeinitAllModules()
        {
            foreach (PixelBlackboardModule userModule in this.userBlackboardModuleList)
            {
                userModule.OnBlackboardUnload(this);
            }
            foreach (PixelBlackboardModule builtInModule in this.builtInBlackboardModuleList)
            {
                builtInModule.OnBlackboardUnload(this);
            }
        }
        #endregion //Private

        #region Public
        public bool GetBlackboardModule<T>(string key, out T blackboardModule) where T : PixelBlackboardModule
        {
            if (this.blackboardModuleDictionary.ContainsKey(key))
            {
                blackboardModule = this.blackboardModuleDictionary[key] as T;
                return true;
            }
            else
            {
                blackboardModule = null;
                return false;
            }
        }
        #endregion //Public
        #endregion //Methods
    }
}