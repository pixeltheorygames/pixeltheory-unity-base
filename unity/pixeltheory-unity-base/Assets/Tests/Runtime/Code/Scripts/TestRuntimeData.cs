using Pixeltheory;
using Pixeltheory.Blackboard;
using Pixeltheory.Debug;
using UnityEngine;

//[CreateAssetMenu(fileName ="TestRuntimeData", menuName = "Pixeltheory/Tests/Data/TestRuntimeData")]
public class TestRuntimeData 
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
    #region PixelObject
    #endregion PixelObject
    #endregion //Methods
}
