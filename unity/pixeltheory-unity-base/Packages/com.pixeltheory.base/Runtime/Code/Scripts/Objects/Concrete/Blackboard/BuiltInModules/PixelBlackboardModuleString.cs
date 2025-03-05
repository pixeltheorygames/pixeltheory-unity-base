using System;
using System.Collections.Generic;


namespace Pixeltheory.Blackboard
{
    public class PixelBlackboardModuleString : PixelBlackboardModule
    {
        #region Fields
        #region Public
        public const string moduleKey = "BuiltInBlackboardModuleString";
        #endregion //Public
        
        #region Private
        [NonSerialized] private Dictionary<string, string> stringDataDictionary;
        #endregion //Private
        #endregion //Fields
        
        #region Properties
        #region Public
        public override string ModuleKey => PixelBlackboardModuleString.moduleKey;
        #endregion //Public
        #endregion //Properties
        
        #region Methods
        #region PixelBlackboardModule Overrides
        public override void OnBlackboardLoad(PixelBlackboard blackboard)
        {
            this.stringDataDictionary = new Dictionary<string, string>();
        }
        
        public override void OnBlackboardUnload(PixelBlackboard blackboard)
        {
            this.stringDataDictionary.Clear();
            this.stringDataDictionary = null;
        }
        #endregion //PixelBlackboardModule Overrides

        #region Public
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