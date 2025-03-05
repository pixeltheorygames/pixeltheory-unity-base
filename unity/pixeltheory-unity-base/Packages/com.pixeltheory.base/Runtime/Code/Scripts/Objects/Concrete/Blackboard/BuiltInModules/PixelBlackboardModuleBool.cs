using System;
using System.Collections.Generic;


namespace Pixeltheory.Blackboard
{
    public class PixelBlackboardModuleBool : PixelBlackboardModule
    {
        #region Fields
        #region Public
        public const string moduleKey = "BuiltInBlackboardModuleBool";
        #endregion //Public
        
        #region Private
        [NonSerialized] private Dictionary<string, bool> boolDataDictionary;
        #endregion //Private
        #endregion //Fields
        
        #region Properties
        #region Public
        public override string ModuleKey => PixelBlackboardModuleBool.moduleKey;
        #endregion //Public
        #endregion //Properties
        
        #region Methods
        #region PixelBlackboardModule Overrides
        public override void OnBlackboardLoad(PixelBlackboard blackboard)
        {
            this.boolDataDictionary = new Dictionary<string, bool>();
        }
        
        public override void OnBlackboardUnload(PixelBlackboard blackboard)
        {
            this.boolDataDictionary.Clear();
            this.boolDataDictionary = null;
        }
        #endregion //PixelBlackboardModule Overrides

        #region Public
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
        #endregion //Public
        #endregion //Methods
    }
}