using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class CameraEvent : UnityEvent<Camera> { }

	[CreateAssetMenu(
	    fileName = "CameraVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Camera",
	    order = 120)]
	public class CameraVariable : BaseVariable<Camera, CameraEvent>
	{
	}
}