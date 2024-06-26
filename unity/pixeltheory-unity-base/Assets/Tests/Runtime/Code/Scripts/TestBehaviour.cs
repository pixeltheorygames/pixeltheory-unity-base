using System.Collections;
using Pixeltheory;
using Pixeltheory.Debug;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestBehaviour : PixelBehaviour<TestRuntimeData>
{
    #region Methods
    #region Unity Messages
    private void Start()
    {
        //PixelLog.Log(this.Blackboard.Data.TestString);

        if (SceneManager.GetActiveScene().name == "SampleSceneDataOne")
        { 
            //this.StartCoroutine(this.TransitionToSampleSceneDataTwo(5.0f));
        }
    }
    #endregion //Unity Messages

    #region Private
    private IEnumerator TransitionToSampleSceneDataTwo(float delayInSeconds)
    {
        yield return new WaitForSeconds(delayInSeconds);
        AsyncOperation loadAsyncOp = SceneManager.LoadSceneAsync("SampleSceneDataTwo");
    }
    #endregion //Private
    #endregion //Methods
}
