using System;
using System.Collections.Generic;
using UnityEngine;


namespace Pixeltheory.Blackboard
{
    [CreateAssetMenu(fileName = "PixelBlackboard", menuName = "Pixeltheory/Blackboard/PixelBlackboard", order = 0)]
    public partial class PixelBlackboard : PixelObject
    {
        #region Class
        #region Fields
        #region Private
        private static bool RuntimeInstantiationDisabled = false;
        #endregion //Private
        #endregion //Fields
        #endregion //Class

        #region Instance
        #region Fields
        #region Inspector
        [SerializeField] private List<PixelBlackboardModule> blackboardModuleGroupList;
        #endregion //Inspector

        #region Private
        [NonSerialized] private List<PixelBlackboardModule> builtInBlackboardModuleList;
        [NonSerialized] private List<PixelBlackboardModule> userBlackboardModuleList;
        [NonSerialized] private Dictionary<string, PixelBlackboardModule> blackboardModuleDictionary;
        #endregion //Private
        #endregion //Fields
        
        #region Methods
        #region PixelObject Overrides
        protected override void OnObjectAwake()
        {
            if (PixelBlackboard.RuntimeInstantiationDisabled)
            {
                UnityEngine.Object.Destroy(this);
                return;
            }
            PixelBlackboard.RuntimeInstantiationDisabled = true;
            base.OnObjectAwake();
            this.builtInBlackboardModuleList = new List<PixelBlackboardModule>();
            this.userBlackboardModuleList = new List<PixelBlackboardModule>();
            this.blackboardModuleDictionary = new Dictionary<string, PixelBlackboardModule>();
            PixelRuntimeDataModule builtInModule = PixelObject.CreateInstance<PixelRuntimeDataModule>();
            this.builtInBlackboardModuleList.Add(builtInModule);
            this.blackboardModuleDictionary.Add(builtInModule.ModuleKey, builtInModule);
        }

        protected override void OnObjectEnable()
        {
            if (PixelBlackboard.RuntimeInstantiationDisabled)
            {
                return;
            }
            base.OnObjectEnable();
        }
        #endregion //PixelObject Overrides

        #region Public
        public T GetBlackboardModule<T>(string key) where T : PixelBlackboardModule
        {
            if (this.blackboardModuleDictionary.ContainsKey(key))
            {
                return this.blackboardModuleDictionary[key] as T;
            }
            return null;
        }
        
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
        #endregion //Instance
    }
}