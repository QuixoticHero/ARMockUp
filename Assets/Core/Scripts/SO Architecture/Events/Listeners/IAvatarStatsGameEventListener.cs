using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "IAvatarStats")]
	public sealed class IAvatarStatsGameEventListener : BaseGameEventListener<IAvatarStats, IAvatarStatsGameEvent, IAvatarStatsUnityEvent>
	{
	}
}