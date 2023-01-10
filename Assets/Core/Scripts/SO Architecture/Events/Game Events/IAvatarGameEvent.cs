using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "IAvatarGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "IAvatar",
	    order = 120)]
	public sealed class IAvatarGameEvent : GameEventBase<IAvatar>
	{
	}
}