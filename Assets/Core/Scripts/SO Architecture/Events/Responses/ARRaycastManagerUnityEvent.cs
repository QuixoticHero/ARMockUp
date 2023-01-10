using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class ARRaycastManagerUnityEvent : UnityEvent<UnityEngine.XR.ARFoundation.ARRaycastManager>
	{
	}
}