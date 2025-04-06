namespace Pixeltheory.Blackboard
{
    public static class PixelRuntimeDataModuleExtensions
    {
        public static bool AddOrUpdateIntData(this PixelBlackboard blackboard, string key, int data)
        {
            PixelRuntimeDataModule builtInModule;
            if (blackboard.GetBlackboardModule(PixelRuntimeDataModule.moduleKey, out builtInModule))
            {
                return builtInModule.AddOrUpdateIntData(key, data);
            }
            else
            {
                return false;
            }
        }
        
        public static bool GetIntData(this PixelBlackboard blackboard, string key, out int data)
        {
            PixelRuntimeDataModule builtInModule;
            if (blackboard.GetBlackboardModule(PixelRuntimeDataModule.moduleKey, out builtInModule))
            {
                return builtInModule.GetIntData(key, out data);
            }
            else
            {
                data = 0;
                return false;
            }
        }

        public static bool RemoveIntData(this PixelBlackboard blackboard, string key)
        {
            PixelRuntimeDataModule builtInModule;
            if (blackboard.GetBlackboardModule(PixelRuntimeDataModule.moduleKey, out builtInModule))
            {
                return builtInModule.RemoveIntData(key);
            }
            else
            {
                return false;
            }
        }
        
        public static bool AddOrUpdateBoolData(this PixelBlackboard blackboard, string key, bool data)
        {
            PixelRuntimeDataModule builtInModule;
            if (blackboard.GetBlackboardModule(PixelRuntimeDataModule.moduleKey, out builtInModule))
            {
                return builtInModule.AddOrUpdateBoolData(key, data);
            }
            else
            {
                return false;
            }
        }

        public static bool GetBoolData(this PixelBlackboard blackboard, string key, out bool data)
        {
            PixelRuntimeDataModule builtInModule;
            if (blackboard.GetBlackboardModule(PixelRuntimeDataModule.moduleKey, out builtInModule))
            {
                return builtInModule.GetBoolData(key, out data);
            }
            else
            {
                data = false;
                return false;
            }
        }

        public static bool RemoveBoolData(this PixelBlackboard blackboard, string key)
        {
            PixelRuntimeDataModule builtInModule;
            if (blackboard.GetBlackboardModule(PixelRuntimeDataModule.moduleKey, out builtInModule))
            {
                return builtInModule.RemoveBoolData(key);
            }
            else
            {
                return false;
            }
        }
        
        public static bool AddOrUpdateFloatData(this PixelBlackboard blackboard, string key, float data)
        {
            PixelRuntimeDataModule builtInModule;
            if (blackboard.GetBlackboardModule(PixelRuntimeDataModule.moduleKey, out builtInModule))
            {
                return builtInModule.AddOrUpdateFloatData(key, data);
            }
            else
            {
                return false;
            }
        }

        public static bool GetFloatData(this PixelBlackboard blackboard, string key, out float data)
        {
            PixelRuntimeDataModule builtInModule;
            if (blackboard.GetBlackboardModule(PixelRuntimeDataModule.moduleKey, out builtInModule))
            {
                return builtInModule.GetFloatData(key, out data);
            }
            else
            {
                data = 0.0f;
                return false;
            }
        }

        public static bool RemoveFloatData(this PixelBlackboard blackboard, string key)
        {
            PixelRuntimeDataModule builtInModule;
            if (blackboard.GetBlackboardModule(PixelRuntimeDataModule.moduleKey, out builtInModule))
            {
                return builtInModule.RemoveFloatData(key);
            }
            else
            {
                return false;
            }
        }
        
        public static bool AddOrUpdateStringData(this PixelBlackboard blackboard, string key, string data)
        {
            PixelRuntimeDataModule builtInModule;
            if (blackboard.GetBlackboardModule(PixelRuntimeDataModule.moduleKey, out builtInModule))
            {
                return builtInModule.AddOrUpdateStringData(key, data);
            }
            else
            {
                return false;
            }
        }

        public static bool GetStringData(this PixelBlackboard blackboard, string key, out string data)
        {
            PixelRuntimeDataModule builtInModule;
            if (blackboard.GetBlackboardModule(PixelRuntimeDataModule.moduleKey, out builtInModule))
            {
                return builtInModule.GetStringData(key, out data);
            }
            else
            {
                data = null;
                return false;
            }
        }

        public static bool RemoveStringData(this PixelBlackboard blackboard, string key)
        {
            PixelRuntimeDataModule builtInModule;
            if (blackboard.GetBlackboardModule(PixelRuntimeDataModule.moduleKey, out builtInModule))
            {
                return builtInModule.RemoveStringData(key);
            }
            else
            {
                return false;
            }
        }
    }
}