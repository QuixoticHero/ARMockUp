using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class IAvatarEvent : UnityEvent<IAvatar> { }

	[CreateAssetMenu(
	    fileName = "IAvatarVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "IAvatar",
	    order = 120)]
	public class IAvatarVariable : BaseVariable<IAvatar, IAvatarEvent>
	{
	}
}