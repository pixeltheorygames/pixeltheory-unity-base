using UnityEngine;
using UnityEngine.Assertions;
using Pixeltheory.Blackboard;


namespace Pixeltheory
{
    public abstract class PixelBehaviour : MonoBehaviour 
    {
        #region Instance
        #region Fields
        #region Inspector
        [Header("PixelBehaviour")]
        [SerializeField] protected PixelBlackboard blackboard;
        [SerializeField] protected Transform prefabRootTransform;
        #endregion //Inspector    
        #endregion //Fields

        #region Properties
        #region Public
        public Transform PrefabRootTransform => this.prefabRootTransform;
        #endregion //Public
        #endregion //Properties

        #region Methods
        #region Unity Messages
        protected virtual void Awake()
        {
            Assert.IsNotNull(this.prefabRootTransform);
            Assert.IsNotNull(this.blackboard);
        }
        #endregion //Unity Messages
        #endregion //Methods
        #endregion //Instance
    }
}
