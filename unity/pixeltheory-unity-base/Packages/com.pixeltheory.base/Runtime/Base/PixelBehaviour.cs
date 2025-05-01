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
        [SerializeField] private PixelBlackboard blackboard;
        [SerializeField] private Transform prefabRootTransform;
        #endregion //Inspector    
        #endregion //Fields

        #region Properties
        #region Protected
        protected PixelBlackboard Blackboard => this.blackboard;
        protected Transform PrefabRootTransform => this.prefabRootTransform;
        #endregion //Protected
        #endregion //Properties

        #region Methods
        #region Unity Messages
        protected virtual void Awake()
        {
            Assert.IsNotNull(this.blackboard);
            Assert.IsNotNull(this.prefabRootTransform);
        }
        #endregion //Unity Messages
        #endregion //Methods
        #endregion //Instance
    }
}
