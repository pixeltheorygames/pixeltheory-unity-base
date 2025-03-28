using System;
using System.Collections.Generic;


namespace Pixeltheory.Blackboard
{
    public class PixelBlackboardModuleRuntimeData : PixelBlackboardModule
    {
        #region Fields
        #region Public
        public const string moduleKey = "BlackboardModuleRuntimeData";
        #endregion //Public
        
        #region Private
        [NonSerialized] private Dictionary<string, int> intDataDictionary;
        [NonSerialized] private Dictionary<string, bool> boolDataDictionary;
        [NonSerialized] private Dictionary<string, float> floatDataDictionary;
        [NonSerialized] private Dictionary<string, string> stringDataDictionary;
        #endregion //Private
        #endregion //Fields

        #region Properties
        #region PixelBlackboardModule Overrides
        public override string ModuleKey => PixelBlackboardModuleRuntimeData.moduleKey;
        #endregion //PixelBlackboardModule Overrides
        #endregion //Properties
        
        #region Methods
        #region PixelBlackboardModule Overrides
        public override void OnBlackboardLoad(PixelBlackboard blackboard)
        {
            this.intDataDictionary = new Dictionary<string, int>();
            this.boolDataDictionary = new Dictionary<string, bool>();
            this.floatDataDictionary = new Dictionary<string, float>();
            this.stringDataDictionary = new Dictionary<string, string>();
        }
        
        public override void OnBlackboardUnload(PixelBlackboard blackboard)
        {
            this.intDataDictionary.Clear();
            this.intDataDictionary = null;
            this.boolDataDictionary.Clear();
            this.boolDataDictionary = null;
            this.floatDataDictionary.Clear();
            this.floatDataDictionary = null;
            this.stringDataDictionary.Clear();
            this.stringDataDictionary = null;
        }
        #endregion //PixelBlackboardModule Overrides

        #region Public
        public bool AddOrUpdateIntData(string key, int data)
        {
            if (this.intDataDictionary.ContainsKey(key))
            {
                this.intDataDictionary[key] = data;
                return true;
            }
            else
            {
                this.intDataDictionary.Add(key, data);
                return false;
            }
        }

        public bool GetIntData(string key, out int data)
        {
            if (this.intDataDictionary.ContainsKey(key))
            {
                data = this.intDataDictionary[key];
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
            if (this.intDataDictionary.ContainsKey(key))
            {
                this.intDataDictionary.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool AddOrUpdateBoolData(string key, bool data)
        {
            if (this.boolDataDictionary.ContainsKey(key))
            {
                this.boolDataDictionary[key] = data;
                return true;
            }
            else
            {
                this.boolDataDictionary.Add(key, data);
                return false;
            }
        }

        public bool GetBoolData(string key, out bool data)
        {
            if (this.boolDataDictionary.ContainsKey(key))
            {
                data = this.boolDataDictionary[key];
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
            if (this.boolDataDictionary.ContainsKey(key))
            {
                this.boolDataDictionary.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool AddOrUpdateFloatData(string key, float data)
        {
            if (this.floatDataDictionary.ContainsKey(key))
            {
                this.floatDataDictionary[key] = data;
                return true;
            }
            else
            {
                this.floatDataDictionary.Add(key, data);
                return false;
            }
        }

        public bool GetFloatData(string key, out float data)
        {
            if (this.floatDataDictionary.ContainsKey(key))
            {
                data = this.floatDataDictionary[key];
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
            if (this.floatDataDictionary.ContainsKey(key))
            {
                this.floatDataDictionary.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool AddOrUpdateStringData(string key, string data)
        {
            if (this.stringDataDictionary.ContainsKey(key))
            {
                this.stringDataDictionary[key] = data;
                return true;
            }
            else
            {
                this.stringDataDictionary.Add(key, data);
                return false;
            }
        }

        public bool GetStringData(string key, out string data)
        {
            if (this.stringDataDictionary.ContainsKey(key))
            {
                data = this.stringDataDictionary[key];
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
            if (this.stringDataDictionary.ContainsKey(key))
            {
                this.stringDataDictionary.Remove(key);
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