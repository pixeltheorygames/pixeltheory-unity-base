using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Pixeltheory.Blackboard
{
    [CreateAssetMenu(fileName = "PixelBlackboard", menuName = "Pixeltheory/Data/PixelBlackboard")]
    public class PixelBlackboard : PixelObject
    {
        #region Fields
        #region Inspector
        [SerializeField] private List<PixelBlackboardModuleGroup> blackboardModuleGroupList;
        #endregion //Inspector

        #region Private
        [NonSerialized] private List<PixelBlackboardModule> blackboardModuleList;
        [NonSerialized] private Dictionary<string, int> intDataMap;
        [NonSerialized] private Dictionary<string, float> floatDataMap;
        [NonSerialized] private Dictionary<string, string> stringDataMap;
        [NonSerialized] private Dictionary<string, bool> boolDataMap;
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
            this.DataMapsInit();
            this.blackboardModuleList = this.blackboardModuleGroupList[0].Modules;
            foreach (PixelBlackboardModuleGroup sceneAndDataListPair in this.blackboardModuleGroupList)
            {
                if (sceneAndDataListPair.SceneName == SceneManager.GetActiveScene().name)
                {
                    this.blackboardModuleList = sceneAndDataListPair.Modules;
                }
            }
            for (int i = 0; i < this.blackboardModuleList.Count; i++)
            {
                this.blackboardModuleList[i].OnBlackboardLoad(this);
            }
        }

        private void OnBlackboardUnload(PixelBlackboard blackboard)
        {
            for (int i = this.blackboardModuleList.Count - 1 ; i > -1; i--)
            {
                this.blackboardModuleList[i].OnBlackboardUnload(this);
            }
            this.blackboardModuleList = null;
            this.DataMapsDeinit();
        }

        private void DataMapsInit()
        {
            this.intDataMap = new Dictionary<string, int>();
            this.floatDataMap = new Dictionary<string, float>();
            this.stringDataMap = new Dictionary<string, string>();
            this.boolDataMap = new Dictionary<string, bool>();
        }

        private void DataMapsDeinit()
        {
            this.boolDataMap.Clear();
            this.boolDataMap = null;
            this.stringDataMap.Clear();
            this.stringDataMap = null;
            this.floatDataMap.Clear();
            this.floatDataMap = null;
            this.intDataMap.Clear();
            this.intDataMap = null;
        }
        #endregion //Private

        #region Public
        public bool AddOrUpdateIntData(string key, int data)
        {
            if (this.intDataMap.ContainsKey(key))
            {
                this.intDataMap[key] = data;
                return true;
            }
            else
            {
                this.intDataMap.Add(key, data);
                return false;
            }
        }

        public bool GetIntData(string key, out int data)
        {
            if (this.intDataMap.ContainsKey(key))
            {
                data = this.intDataMap[key];
                return true;
            }
            else
            {
                data = 0;
                return false;
            }
        }

        public bool RemoveIntData(string key)
        {
            if (this.intDataMap.ContainsKey(key))
            {
                this.intDataMap.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool AddOrUpdateFloatData(string key, float data)
        {
            if (this.floatDataMap.ContainsKey(key))
            {
                this.floatDataMap[key] = data;
                return true;
            }
            else
            {
                this.floatDataMap.Add(key, data);
                return false;
            }
        }

        public bool GetFloatData(string key, out float data)
        {
            if (this.floatDataMap.ContainsKey(key))
            {
                data = this.floatDataMap[key];
                return true;
            }
            else
            {
                data = 0.0f;
                return false;
            }
        }

        public bool RemoveFloatData(string key)
        {
            if (this.floatDataMap.ContainsKey(key))
            {
                this.floatDataMap.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool AddOrUpdateStringData(string key, string data)
        {
            if (this.stringDataMap.ContainsKey(key))
            {
                this.stringDataMap[key] = data;
                return true;
            }
            else
            {
                this.stringDataMap.Add(key, data);
                return false;
            }
        }

        public bool GetStringData(string key, out string data)
        {
            if (this.stringDataMap.ContainsKey(key))
            {
                data = this.stringDataMap[key];
                return true;
            }
            else
            {
                data = null;
                return false;
            }
        }

        public bool RemoveStringData(string key)
        {
            if (this.stringDataMap.ContainsKey(key))
            {
                this.stringDataMap.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool AddOrUpdateBoolData(string key, bool data)
        {
            if (this.boolDataMap.ContainsKey(key))
            {
                this.boolDataMap[key] = data;
                return true;
            }
            else
            {
                this.boolDataMap.Add(key, data);
                return false;
            }
        }

        public bool GetBoolData(string key, out bool data)
        {
            if (this.boolDataMap.ContainsKey(key))
            {
                data = this.boolDataMap[key];
                return true;
            }
            else
            {
                data = false;
                return false;
            }
        }

        public bool RemoveBoolData(string key)
        {
            if (this.boolDataMap.ContainsKey(key))
            {
                this.boolDataMap.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion //Public
        #endregion //Methods
    }
}