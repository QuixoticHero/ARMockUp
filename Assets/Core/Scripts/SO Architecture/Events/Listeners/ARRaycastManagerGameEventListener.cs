using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "AR/ARRaycastManager")]
	public sealed class ARRaycastManagerGameEventListener : BaseGameEventListener<UnityEngine.XR.ARFoundation.ARRaycastManager, ARRaycastManagerGameEvent, ARRaycastManagerUnityEvent>
	{
	}
}