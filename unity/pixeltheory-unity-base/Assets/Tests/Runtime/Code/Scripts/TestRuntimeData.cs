using Pixeltheory;
using UnityEngine;

[CreateAssetMenu(fileName ="TestRuntimeData", menuName = "Pixeltheory/Tests/Data/TestRuntimeData")]
public class TestRuntimeData : PixelObject
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
}
