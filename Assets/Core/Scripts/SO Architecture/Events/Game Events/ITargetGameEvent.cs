using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "ITargetGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "ITarget",
	    order = 120)]
	public sealed class ITargetGameEvent : GameEventBase<ITarget>
	{
	}
}