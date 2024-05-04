using Pixeltheory;
using Pixeltheory.Blackboard;
using Pixeltheory.Debug;
using UnityEngine;

[CreateAssetMenu(fileName ="TestRuntimeData", menuName = "Pixeltheory/Tests/Data/TestRuntimeData")]
public class TestRuntimeData : PixelBlackboardData
{
    #region Fields
    #region Inspector
    [SerializeField] private string testString;
    #endregion //Inspector
    #endregion //Fields

    #region Properties
    #region Public
    public string TestString => this.testString;
    #endregion //Public
    #endregion //Properties

    #region Methods
    #region PixelBlackboardData
    public override void OnBlackboardLoad()
    {
        PixelLog.Log("TestRuntimeData Loaded");
    }
    
    public override void OnBlackboardUnload()
    {
        PixelLog.Log("TestRuntimeData Unloaded");
    }
    #endregion //PixelBlackboardData
    #endregion //Methods
}
