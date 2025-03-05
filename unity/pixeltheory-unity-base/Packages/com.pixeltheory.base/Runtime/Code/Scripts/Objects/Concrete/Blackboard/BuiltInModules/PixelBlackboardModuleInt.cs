using System;
using System.Collections.Generic;


namespace Pixeltheory.Blackboard
{
    public class PixelBlackboardModuleInt : PixelBlackboardModule
    {
        #region Fields
        #region Public
        public const string moduleKey = "BuiltInBlackboardModuleInt";
        #endregion //Public
        
        #region Private
        [NonSerialized] private Dictionary<string, int> intDataDictionary;
        #endregion //Private
        #endregion //Fields

        #region Properties
        #region Public
        public override string ModuleKey => PixelBlackboardModuleInt.moduleKey;
        #endregion //Public
        #endregion //Properties
        
        #region Methods
        #region PixelBlackboardModule Overrides
        public override void OnBlackboardLoad(PixelBlackboard blackboard)
        {
            this.intDataDictionary = new Dictionary<string, int>();
        }
        
        public override void OnBlackboardUnload(PixelBlackboard blackboard)
        {
            this.intDataDictionary.Clear();
            this.intDataDictionary = null;
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
        #endregion //Public
        #endregion //Methods
    }

}