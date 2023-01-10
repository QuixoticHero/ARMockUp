using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class ITargetEvent : UnityEvent<ITarget> { }

	[CreateAssetMenu(
	    fileName = "ITargetVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "ITarget",
	    order = 120)]
	public class ITargetVariable : BaseVariable<ITarget, ITargetEvent>
	{
	}
}