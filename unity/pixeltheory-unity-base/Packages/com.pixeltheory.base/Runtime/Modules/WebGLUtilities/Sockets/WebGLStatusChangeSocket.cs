using UnityEngine;
using Pixeltheory.Switchboard;

namespace Pixeltheory.WebGLUtilities
{
	[CreateAssetMenu(fileName = "WebGLStatusChangeSocket", 
		menuName = "Pixeltheory/Switchboard/Sockets/WebGLStatusChangeSocket")]
	public class WebGLStatusChangeSocket : PixelSocket<WebGLStatusChangeSocket>
	{
		#region Fields
		#region Public
		public bool isFullscreen;
		#endregion //Public
		#endregion //Public
	}
}