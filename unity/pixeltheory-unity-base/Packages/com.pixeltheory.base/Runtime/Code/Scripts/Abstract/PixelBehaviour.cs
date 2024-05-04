using UnityEngine;
using UnityEngine.Assertions;
using Pixeltheory.Blackboard;


namespace Pixeltheory
{
    public abstract class PixelBehaviour<BlackboardDataType> : MonoBehaviour
        where BlackboardDataType : PixelBlackboardData
    {

    #region Instance
    #region Fields
    #region Inspector
    [Header("PixelBehaviour")]
    [SerializeField] private Transform rootTransform;
    [SerializeField] private PixelBlackboard blackboard;
    #endregion //Inspector    
    #endregion //Fields

    #region Properties
    #region Protected
    protected int RootID => this.rootTransform.GetInstanceID();
    protected int PixelBehaviourID => this.GetInstanceID();
    protected Transform RootTransform => this.rootTransform;
    protected BlackboardDataType Blackboard => this.blackboard.Data as BlackboardDataType;
    #endregion //Protected
    #endregion //Properties

    #region Methods
    #region Unity Messages
    protected virtual void Awake()
    {
        Assert.IsNotNull(this.rootTransform);
        Assert.IsNotNull(this.blackboard);
    }
    #endregion //Unity Messages
    #endregion //Methods
    #endregion //Instance

    }
}
