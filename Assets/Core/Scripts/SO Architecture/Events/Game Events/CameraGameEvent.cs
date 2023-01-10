using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "CameraGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Camera",
	    order = 120)]
	public sealed class CameraGameEvent : GameEventBase<Camera>
	{
	}
}