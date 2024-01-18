using Pixeltheory.Debug;
using UnityEngine;
using UnityEngine.Assertions;


namespace Pixeltheory
{
    public abstract class PixelBehaviour<TypeBlackboard, TypeData> : MonoBehaviour
        where TypeBlackboard : PixelBlackboard<TypeData> 
        where TypeData : PixelObject
    {

    #region Instance
    #region Fields
    #region Inspector
    [Header("PixelBehaviour")]
    [SerializeField] private Transform rootTransform;
    [SerializeField] private TypeBlackboard blackboard;
    #endregion //Inspector    
    #endregion //Fields

    #region Properties
    #region Protected
    protected int RootID => this.rootTransform.GetInstanceID();
    protected int PixelBehaviourID => this.GetInstanceID();
    protected Transform RootTransform => this.rootTransform;
    protected TypeBlackboard Blackboard => this.blackboard;
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
