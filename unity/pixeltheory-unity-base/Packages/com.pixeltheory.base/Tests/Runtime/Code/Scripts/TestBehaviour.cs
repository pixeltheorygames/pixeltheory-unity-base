using System.Collections;
using Pixeltheory.Blackboard;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestBehaviour : MonoBehaviour
{
    #region Fields
    #region Inspector
    [SerializeField] private PixelBlackboard pixelBlackboard;
    //[SerializeField] private TestPixelObject testPixelObject;
    #endregion //Inspector
    #endregion //Fields
    
    #region Methods
    #region Private
    private IEnumerator TransitionToSampleSceneDataTwo(float delayInSeconds)
    {
        yield return new WaitForSeconds(delayInSeconds);
        AsyncOperation loadAsyncOp = SceneManager.LoadSceneAsync("SampleSceneDataTwo");
    }
    #endregion //Private
    #endregion //Methods
}
