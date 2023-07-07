﻿using Pixeltheory.Debug;
using UnityEngine;


namespace Pixeltheory
{
    public abstract class PixelBehaviour<TypeSelf, TypeData> : MonoBehaviour 
        where TypeSelf : PixelBehaviour<TypeSelf, TypeData>
        where TypeData : PixelBlackboard<TypeData>
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
        [SerializeField] private TypeData blackboard;
        #endregion //Inspector

        #region Protected
        
        #endregion //Protected

        #region Private
        private bool isBeingDestroyed = false;
        private readonly string fullName = typeof(TypeSelf).FullName;
        #endregion //Private
        #endregion //Fields
        
        #region Properties
        #region Protected
        protected TypeData Blackboard => this.blackboard;
        protected bool IsBeingDestroyed => this.isBeingDestroyed;
        protected string PixelBehaviourFullName => this.fullName;
        #endregion //Protected
        #endregion //Properties
        
        #region Methods
        #region Unity Messages
        protected virtual void Awake()
        {
            bool destroySelf = false;
            if (this.onlyAllowSingleInstance)
            {
                if (PixelBehaviour<TypeSelf, TypeData>.instance == null)
                {
                    PixelBehaviour<TypeSelf, TypeData>.instance = this as TypeSelf;
                    PixelLog.Log("[{0}] Setting first instance as single instance.", this.fullName);
                }
                else if (PixelBehaviour<TypeSelf, TypeData>.instance.GetInstanceID() != this.GetInstanceID())
                {
                    
                    if (PixelBehaviour<TypeSelf, TypeData>.instance.isBeingDestroyed 
                        && !PixelBehaviour<TypeSelf, TypeData>.gameIsShuttingDown)
                    {
                        PixelBehaviour<TypeSelf, TypeData>.instance = this as TypeSelf;
                        PixelLog.Log
                        (
                            "[{0}] Changing single instance due to current single instance being destroyed.",
                            this.fullName
                        );
                    }
                    else
                    {
                        destroySelf = true;
                    }
                }
            }
            if (destroySelf)
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
            }
            else
            {
                this.blackboard = this.blackboard.SharedInstance;
            }
        }

        protected virtual void OnDestroy()
        {
            this.isBeingDestroyed = true;
            if (this.onlyAllowSingleInstance && PixelBehaviour<TypeSelf, TypeData>.instance == this as TypeSelf)
            {
                PixelBehaviour<TypeSelf, TypeData>.instance = null;
                PixelLog.Log("[{0}] Singleton instance is being destroyed.", this.fullName);
            }
        }

        protected virtual void OnApplicationQuit()
        {
            PixelBehaviour<TypeSelf, TypeData>.gameIsShuttingDown = true;
        }
        #endregion //Unity Messages
        #endregion //Methods
        #endregion //Instance
    }
}
