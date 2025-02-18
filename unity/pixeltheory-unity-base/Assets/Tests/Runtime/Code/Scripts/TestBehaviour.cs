using System;
using System.Collections;
using Pixeltheory;
using Pixeltheory.Blackboard;
using Pixeltheory.Debug;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class TestBehaviour : MonoBehaviour
{
    #region Fields
    #region Inspector
    [SerializeField] private PixelBlackboard pixelBlackboard;
    #endregion //Inspector
    #endregion //Fields
    
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

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadSceneAsync("SampleScene").allowSceneActivation = true;
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
