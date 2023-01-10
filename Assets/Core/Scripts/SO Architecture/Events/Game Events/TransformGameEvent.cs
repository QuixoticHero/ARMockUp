using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "TransformGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Transform",
	    order = 120)]
	public sealed class TransformGameEvent : GameEventBase<UnityEngine.Transform>
	{
	}
}