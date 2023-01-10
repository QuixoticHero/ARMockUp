using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "ARRaycastManagerGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "AR/ARRaycastManager",
	    order = 120)]
	public sealed class ARRaycastManagerGameEvent : GameEventBase<UnityEngine.XR.ARFoundation.ARRaycastManager>
	{
	}
}