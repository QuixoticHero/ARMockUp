using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "IAvatarStatsGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "IAvatarStats",
	    order = 120)]
	public sealed class IAvatarStatsGameEvent : GameEventBase<IAvatarStats>
	{
	}
}