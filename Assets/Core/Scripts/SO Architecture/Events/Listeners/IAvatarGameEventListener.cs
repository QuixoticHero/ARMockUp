using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "IAvatar")]
	public sealed class IAvatarGameEventListener : BaseGameEventListener<IAvatar, IAvatarGameEvent, IAvatarUnityEvent>
	{
	}
}