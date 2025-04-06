using System.Collections;
using Pixeltheory.Blackboard;
using Pixeltheory.Test;
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
    #region Unity Messages
    private async void Start()
    {
        await Awaitable.WaitForSecondsAsync(3f);
        PixelBlackboard unloading = this.pixelBlackboard;
        this.pixelBlackboard = null;
        Resources.UnloadAsset(unloading);
        await Awaitable.WaitForSecondsAsync(3f);
        
    }

    private void Update()
    {
        // if (Input.anyKeyDown)
        // {
        //     SceneManager.LoadSceneAsync("SampleScene").allowSceneActivation = true;
        // }
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
