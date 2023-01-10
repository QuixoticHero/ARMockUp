using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class ARRaycastManagerEvent : UnityEvent<UnityEngine.XR.ARFoundation.ARRaycastManager> { }

	[CreateAssetMenu(
	    fileName = "ARRaycastManagerVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "AR/ARRaycastManager",
	    order = 120)]
	public class ARRaycastManagerVariable : BaseVariable<UnityEngine.XR.ARFoundation.ARRaycastManager, ARRaycastManagerEvent>
	{
	}
}