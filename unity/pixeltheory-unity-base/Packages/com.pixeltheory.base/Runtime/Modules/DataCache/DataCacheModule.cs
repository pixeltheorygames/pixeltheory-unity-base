using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixeltheory.Blackboard;


namespace Pixeltheory.DataCache
{
    [CreateAssetMenu(fileName = "DataCacheModule", menuName = "Pixeltheory/Blackboard/Modules/DataCache")]
    public abstract class DataCacheModule : PixelBlackboardModule
    {
        #region Fields
        #region Private
        private Dictionary<string, int> intDataDictionary;
        private Dictionary<string, bool> boolDataDictionary;
        private Dictionary<string, float> floatDataDictionary;
        private Dictionary<string, string> stringDataDictionary;
        #endregion //Private
        #endregion //Fields

        #region Methods
        #region PixelObject Overrides
        protected override void OnObjectAwake()
        {
            base.OnObjectAwake();
            this.intDataDictionary = new Dictionary<string, int>();
            this.boolDataDictionary = new Dictionary<string, bool>();
            this.floatDataDictionary = new Dictionary<string, float>();
            this.stringDataDictionary = new Dictionary<string, string>();
        }
        #endregion //PixelObject Overrides
        
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