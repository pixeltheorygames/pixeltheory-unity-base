using System.Threading;
using Pixeltheory.Debug;
using Pixeltheory.Switchboard;
using Pixeltheory.WebGLUtilities;
using UnityEngine;
using UnityEngine.InputSystem;
using Screen = UnityEngine.Device.Screen;

public class TestBehaviour : PixelSocketBehaviour
{
    #region Fields
    #region Inspector
    [SerializeField] private WebGLStatusChangeSocket webGLStatusChangeSocket;
    #endregion //Inspector
    #endregion //Fields
    
    #region Methods
    #region Unity Messages
    protected override void OnEnable()
    {
        this.webGLStatusChangeSocket
            .AddListener
            (
                this.OnWebGLFullscreenStatusChanged,
                this.MulticastTypeName,
                this.UnicastID,
                this.destroyCancellationToken
            );
        
    }

    protected override void OnDisable()
    {
        this.webGLStatusChangeSocket
            .RemoveListener
            (
                this.OnWebGLFullscreenStatusChanged,
                this.MulticastTypeName,
                this.UnicastID,
                this.destroyCancellationToken
            );
    }
    #endregion //Unity Messages
    
    #region Private
    public void EnterFullscreen(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started)
        {
            Time.timeScale = 1.0f;
            Screen.fullScreen = true;    
        }
    }

    public void ExitFullscreen(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started)
        {
            Time.timeScale = 0.0f;
            Screen.fullScreen = false;   
        }
    }
    
    private async Awaitable OnWebGLFullscreenStatusChanged
        (float timestamp, WebGLStatusChangeSocket socket, CancellationToken ct)
    {
        await Awaitable.EndOfFrameAsync(ct);
        PixelLog.Log
        (
            "Is fullscreen supported? {0}. Is currently fullscreen? {1}",
            socket.isFullscreen,
            socket.isFullscreen
        );
    }
    #endregion //Private
    #endregion //Methods
}
