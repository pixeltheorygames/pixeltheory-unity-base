#if UNITY_WEBGL && !UNITY_EDITOR
using System.Threading;
#endif //#if UNITY_WEBGL && !UNITY_EDITOR
using UnityEngine;
using Pixeltheory.Blackboard;
using UnityEngine.Assertions;
using UnityEngine.InputSystem;


namespace Pixeltheory.WebGLUtilities
{
	[CreateAssetMenu(fileName = "WebGLUtilitiesModule", menuName = "Pixeltheory/Blackboard/Modules/WebGLUtilities")]
	public class WebGLUtilitiesModule : PixelBlackboardModule
	{
		#region Fields
		#region Inspector
		[SerializeField] private WebGLStatusChangeSocket webGLStatusChangeSocket;
		#endregion //Inspector

		#region Private
		#if UNITY_WEBGL && !UNITY_EDITOR
		private SemaphoreSlim asyncLock;
		private CancellationTokenSource cts;
		#endif //#if UNITY_WEBGL && !UNITY_EDITOR
		#endregion //Private
		#endregion //Fields
		
		
		#region Methods
		#region PixelObject Overrides
		protected override void OnObjectAwake()
		{
			base.OnObjectAwake();
			Assert.IsNotNull(this.webGLStatusChangeSocket);
		}

		protected override void OnObjectEnable()
		{
			base.OnObjectEnable();
			#if UNITY_WEBGL && !UNITY_EDITOR
			this.asyncLock = new SemaphoreSlim(1);
			this.cts = new CancellationTokenSource();
			#endif //#if UNITY_WEBGL && !UNITY_EDITOR
		}

		protected override void OnObjectDisable()
		{
			#if UNITY_WEBGL && !UNITY_EDITOR
			this.cts.Cancel();
			this.cts.Dispose();
			this.asyncLock.Release(0);
			this.asyncLock.Dispose();
			#endif //#if UNITY_WEBGL && !UNITY_EDITOR
			base.OnObjectDisable();
		}
		#endregion //PixelObject Overrides
		
		#region Public
		#region Input Action Event Handlers
		#pragma warning disable CS1998 
		public async void WebGLFullscreenRequested(InputAction.CallbackContext context)
		{
			#if UNITY_WEBGL && !UNITY_EDITOR
			if (context.started)
			{
				this.webGLStatusChangeSocket.isFullscreen = true;
				await this.asyncLock.WaitAsync();
				Screen.fullScreen = true;
				await this.webGLStatusChangeSocket.Broadcast(true, this.cts.Token);
				this.asyncLock.Release();	
			}
			#endif //#if UNITY_WEBGL && !UNITY_EDITOR
		}

		public async void WebGLFullscreenExitRequested(InputAction.CallbackContext context)
		{
			#if UNITY_WEBGL && !UNITY_EDITOR
			if (context.started)
			{
				this.webGLStatusChangeSocket.isFullscreen = false;
				await this.asyncLock.WaitAsync();
				Screen.fullScreen = false;
				this.webGLStatusChangeSocket.Broadcast(true, this.cts.Token);
				this.asyncLock.Release();	
			}
			#endif //#if UNITY_WEBGL && !UNITY_EDITOR
		}
		#pragma warning restore CS1998
		#endregion //Input Action Event Handlers
		#endregion //Public
		#endregion //Methods
	}
}