namespace Pixeltheory.Blackboard
{
    public static class PixelBlackboardModuleIntExtensions
    {
        public static bool AddOrUpdateIntData(this PixelBlackboard blackboard, string key, int data)
        {
            PixelBlackboardModuleRuntimeData builtInModuleRuntimeData;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleRuntimeData.moduleKey, out builtInModuleRuntimeData))
            {
                return builtInModuleRuntimeData.AddOrUpdateIntData(key, data);
            }
            else
            {
                return false;
            }
        }
        
        public static bool GetIntData(this PixelBlackboard blackboard, string key, out int data)
        {
            PixelBlackboardModuleRuntimeData builtInModuleRuntimeData;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleRuntimeData.moduleKey, out builtInModuleRuntimeData))
            {
                return builtInModuleRuntimeData.GetIntData(key, out data);
            }
            else
            {
                data = 0;
                return false;
            }
        }

        public static bool RemoveIntData(this PixelBlackboard blackboard, string key)
        {
            PixelBlackboardModuleRuntimeData builtInModuleRuntimeData;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleRuntimeData.moduleKey, out builtInModuleRuntimeData))
            {
                return builtInModuleRuntimeData.RemoveIntData(key);
            }
            else
            {
                return false;
            }
        }
        
        public static bool AddOrUpdateBoolData(this PixelBlackboard blackboard, string key, bool data)
        {
            PixelBlackboardModuleRuntimeData builtInModuleRuntimeData;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleRuntimeData.moduleKey, out builtInModuleRuntimeData))
            {
                return builtInModuleRuntimeData.AddOrUpdateBoolData(key, data);
            }
            else
            {
                return false;
            }
        }

        public static bool GetBoolData(this PixelBlackboard blackboard, string key, out bool data)
        {
            PixelBlackboardModuleRuntimeData builtInModuleRuntimeData;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleRuntimeData.moduleKey, out builtInModuleRuntimeData))
            {
                return builtInModuleRuntimeData.GetBoolData(key, out data);
            }
            else
            {
                data = false;
                return false;
            }
        }

        public static bool RemoveBoolData(this PixelBlackboard blackboard, string key)
        {
            PixelBlackboardModuleRuntimeData builtInModuleRuntimeData;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleRuntimeData.moduleKey, out builtInModuleRuntimeData))
            {
                return builtInModuleRuntimeData.RemoveBoolData(key);
            }
            else
            {
                return false;
            }
        }
        
        public static bool AddOrUpdateFloatData(this PixelBlackboard blackboard, string key, float data)
        {
            PixelBlackboardModuleRuntimeData builtInModuleRuntimeData;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleRuntimeData.moduleKey, out builtInModuleRuntimeData))
            {
                return builtInModuleRuntimeData.AddOrUpdateFloatData(key, data);
            }
            else
            {
                return false;
            }
        }

        public static bool GetFloatData(this PixelBlackboard blackboard, string key, out float data)
        {
            PixelBlackboardModuleRuntimeData builtInModuleRuntimeData;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleRuntimeData.moduleKey, out builtInModuleRuntimeData))
            {
                return builtInModuleRuntimeData.GetFloatData(key, out data);
            }
            else
            {
                data = 0.0f;
                return false;
            }
        }

        public static bool RemoveFloatData(this PixelBlackboard blackboard, string key)
        {
            PixelBlackboardModuleRuntimeData builtInModuleRuntimeData;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleRuntimeData.moduleKey, out builtInModuleRuntimeData))
            {
                return builtInModuleRuntimeData.RemoveFloatData(key);
            }
            else
            {
                return false;
            }
        }
        
        public static bool AddOrUpdateStringData(this PixelBlackboard blackboard, string key, string data)
        {
            PixelBlackboardModuleRuntimeData builtInModuleRuntimeData;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleRuntimeData.moduleKey, out builtInModuleRuntimeData))
            {
                return builtInModuleRuntimeData.AddOrUpdateStringData(key, data);
            }
            else
            {
                return false;
            }
        }

        public static bool GetStringData(this PixelBlackboard blackboard, string key, out string data)
        {
            PixelBlackboardModuleRuntimeData builtInModuleRuntimeData;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleRuntimeData.moduleKey, out builtInModuleRuntimeData))
            {
                return builtInModuleRuntimeData.GetStringData(key, out data);
            }
            else
            {
                data = null;
                return false;
            }
        }

        public static bool RemoveStringData(this PixelBlackboard blackboard, string key)
        {
            PixelBlackboardModuleRuntimeData builtInModuleRuntimeData;
            if (blackboard.GetBlackboardModule(PixelBlackboardModuleRuntimeData.moduleKey, out builtInModuleRuntimeData))
            {
                return builtInModuleRuntimeData.RemoveStringData(key);
            }
            else
            {
                return false;
            }
        }
    }
}