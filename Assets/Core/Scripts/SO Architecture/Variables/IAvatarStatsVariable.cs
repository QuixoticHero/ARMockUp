using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class IAvatarStatsEvent : UnityEvent<IAvatarStats> { }

	[CreateAssetMenu(
	    fileName = "IAvatarStatsVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "IAvatarStats",
	    order = 120)]
	public class IAvatarStatsVariable : BaseVariable<IAvatarStats, IAvatarStatsEvent>
	{
	}
}