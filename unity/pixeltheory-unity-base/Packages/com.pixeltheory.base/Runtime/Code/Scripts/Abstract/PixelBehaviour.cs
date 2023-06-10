using Pixeltheory.Debug;
using UnityEngine;

using Object = UnityEngine.Object;


namespace Pixeltheory
{
    public abstract class PixelBehaviour<TypeSelf> : MonoBehaviour where TypeSelf : PixelBehaviour<TypeSelf>
    {
        #region Class
        #region Fields
        #region Private
        private static TypeSelf instance = null;
        private static bool gameIsShuttingDown = false;
        #endregion //Private
        #endregion //Fields
        #endregion //Class

        #region Instance
        #region Fields
        #region Inspector
        [Header("PixelBehaviour")] 
        [SerializeField] private bool onlyAllowSingleInstance = false;
        #endregion //Inspector

        #region Protected
        protected bool isBeingDestroyed = false;
        #endregion //Protected
        #endregion //Fields
        
        #region Methods
        #region Unity Messages
        protected virtual void Awake()
        {
            if (this.onlyAllowSingleInstance)
            {
                string className = typeof(TypeSelf).FullName;
                bool setNewInstance = 
                    !PixelBehaviour<TypeSelf>.gameIsShuttingDown &&
                    PixelBehaviour<TypeSelf>.instance == null || 
                    (PixelBehaviour<TypeSelf>.instance.GetInstanceID() != this.GetInstanceID() 
                        && PixelBehaviour<TypeSelf>.instance.isBeingDestroyed);
                if (setNewInstance)
                {
                    PixelBehaviour<TypeSelf>.instance = this as TypeSelf;
                    PixelLog.Log("[{0}] Setting first instance as single instance.", className);
                }
                else
                {
                    this.isBeingDestroyed = true;
                    if (Application.isEditor && !Application.isPlaying)
                    {
                        GameObject.DestroyImmediate(this as Object);
                    }
                    else
                    {
                        GameObject.Destroy(this as Object);
                    }
                    PixelLog.Warn("[{0}] Instance already exists; destroying self.", className);
                }
            }
        }

        protected virtual void OnDestroy()
        {
            this.isBeingDestroyed = true;
            if (this.onlyAllowSingleInstance && PixelBehaviour<TypeSelf>.instance == this as TypeSelf)
            {
                PixelBehaviour<TypeSelf>.instance = null;
                PixelLog.Log("[{0}] Singleton instance is being destroyed.", typeof(TypeSelf).FullName);
            }
        }

        protected virtual void OnApplicationQuit()
        {
            PixelBehaviour<TypeSelf>.gameIsShuttingDown = true;
        }
        #endregion //Unity Messages
        #endregion //Methods
        #endregion //Instance
    }
    
    public abstract class PixelBehaviour<TypeSelf, TypeData> : PixelBehaviour<TypeSelf> 
        where TypeSelf : PixelBehaviour<TypeSelf>
        where TypeData : PixelObject
    {
        #region Fields
        #region Inspector
        [SerializeField] private Blackboard blackboard;
        #endregion //Inspector

        #region Private
        private TypeData blackboardData;
        #endregion //Private
        #endregion //Fields

        #region Properties
        #region Protected
        protected TypeData BlackboardData => this.blackboardData;
        #endregion //Protected
        #endregion //Properties

        #region Methods
        #region Unity Messages
        protected override void Awake()
        {
            base.Awake();
            if (this.blackboardData == null)
            {
                this.blackboardData = this.blackboard.Data as TypeData;
            }
        }
        #endregion //Unity Messages
        #endregion //Methods
    }
}
