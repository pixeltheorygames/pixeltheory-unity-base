using UnityEngine;


namespace Pixeltheory.Blackboard
{
    public static class PixelBlackboardModuleIntExtensions
    {
        public static bool AddOrUpdateIntData(this PixelBlackboard blackboard, string key, int data)
        {
            PixelBlackboardModuleInt builtInModuleInt;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleInt.moduleKey, out builtInModuleInt))
            {
                return builtInModuleInt.AddOrUpdateIntData(key, data);
            }
            else
            {
                return false;
            }
        }
        
        public static bool GetIntData(this PixelBlackboard blackboard, string key, out int data)
        {
            PixelBlackboardModuleInt builtInModuleInt;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleInt.moduleKey, out builtInModuleInt))
            {
                return builtInModuleInt.GetIntData(key, out data);
            }
            else
            {
                data = 0;
                return false;
            }
        }

        public static bool RemoveIntData(this PixelBlackboard blackboard, string key)
        {
            PixelBlackboardModuleInt builtInModuleInt;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleInt.moduleKey, out builtInModuleInt))
            {
                return builtInModuleInt.RemoveIntData(key);
            }
            else
            {
                return false;
            }
        }
        
        public static bool AddOrUpdateBoolData(this PixelBlackboard blackboard, string key, bool data)
        {
            PixelBlackboardModuleBool builtInModuleBool;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleBool.moduleKey, out builtInModuleBool))
            {
                return builtInModuleBool.AddOrUpdateBoolData(key, data);
            }
            else
            {
                return false;
            }
        }

        public static bool GetBoolData(this PixelBlackboard blackboard, string key, out bool data)
        {
            PixelBlackboardModuleBool builtInModuleBool;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleBool.moduleKey, out builtInModuleBool))
            {
                return builtInModuleBool.GetBoolData(key, out data);
            }
            else
            {
                data = false;
                return false;
            }
        }

        public static bool RemoveBoolData(this PixelBlackboard blackboard, string key)
        {
            PixelBlackboardModuleBool builtInModuleBool;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleBool.moduleKey, out builtInModuleBool))
            {
                return builtInModuleBool.RemoveBoolData(key);
            }
            else
            {
                return false;
            }
        }
        
        public static bool AddOrUpdateFloatData(this PixelBlackboard blackboard, string key, float data)
        {
            PixelBlackboardModuleFloat builtInModuleFloat;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleFloat.moduleKey, out builtInModuleFloat))
            {
                return builtInModuleFloat.AddOrUpdateFloatData(key, data);
            }
            else
            {
                return false;
            }
        }

        public static bool GetFloatData(this PixelBlackboard blackboard, string key, out float data)
        {
            PixelBlackboardModuleFloat builtInModuleFloat;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleFloat.moduleKey, out builtInModuleFloat))
            {
                return builtInModuleFloat.GetFloatData(key, out data);
            }
            else
            {
                data = 0.0f;
                return false;
            }
        }

        public static bool RemoveFloatData(this PixelBlackboard blackboard, string key)
        {
            PixelBlackboardModuleFloat builtInModuleFloat;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleFloat.moduleKey, out builtInModuleFloat))
            {
                return builtInModuleFloat.RemoveFloatData(key);
            }
            else
            {
                return false;
            }
        }
        
        public static bool AddOrUpdateStringData(this PixelBlackboard blackboard, string key, string data)
        {
            PixelBlackboardModuleString builtInModuleString;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleString.moduleKey, out builtInModuleString))
            {
                return builtInModuleString.AddOrUpdateStringData(key, data);
            }
            else
            {
                return false;
            }
        }

        public static bool GetStringData(this PixelBlackboard blackboard, string key, out string data)
        {
            PixelBlackboardModuleString builtInModuleString;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleString.moduleKey, out builtInModuleString))
            {
                return builtInModuleString.GetStringData(key, out data);
            }
            else
            {
                data = null;
                return false;
            }
        }

        public static bool RemoveStringData(this PixelBlackboard blackboard, string key)
        {
            PixelBlackboardModuleString builtInModuleString;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleString.moduleKey, out builtInModuleString))
            {
                return builtInModuleString.RemoveStringData(key);
            }
            else
            {
                return false;
            }
        }
    }
}