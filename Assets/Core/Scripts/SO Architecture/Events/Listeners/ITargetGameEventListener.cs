using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "ITarget")]
	public sealed class ITargetGameEventListener : BaseGameEventListener<ITarget, ITargetGameEvent, ITargetUnityEvent>
	{
	}
}