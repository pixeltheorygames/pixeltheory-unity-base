using System;
using System.Collections.Generic;


namespace Pixeltheory.Blackboard
{
    public class PixelBlackboardModuleFloat : PixelBlackboardModule
    {
        #region Fields
        #region Public
        public const string moduleKey = "BuiltInBlackboardModuleFloat";
        #endregion //Public
        
        #region Private
        [NonSerialized] private Dictionary<string, float> floatDataDictionary;
        #endregion //Private
        #endregion //Fields
        
        #region Properties
        #region Public
        public override string ModuleKey => PixelBlackboardModuleFloat.moduleKey;
        #endregion //Public
        #endregion //Properties
        
        #region Methods
        #region PixelBlackboardModule Overrides
        public override void OnBlackboardLoad(PixelBlackboard blackboard)
        {
            this.floatDataDictionary = new Dictionary<string, float>();
        }
        
        public override void OnBlackboardUnload(PixelBlackboard blackboard)
        {
            this.floatDataDictionary.Clear();
            this.floatDataDictionary = null;
        }
        #endregion //PixelBlackboardModule Overrides

        #region Public
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
        #endregion //Public
        #endregion //Methods
    }
}