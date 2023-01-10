using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "Camera")]
	public sealed class CameraGameEventListener : BaseGameEventListener<Camera, CameraGameEvent, CameraUnityEvent>
	{
	}
}