using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class ARRaycastManagerReference : BaseReference<UnityEngine.XR.ARFoundation.ARRaycastManager, ARRaycastManagerVariable>
	{
	    public ARRaycastManagerReference() : base() { }
	    public ARRaycastManagerReference(UnityEngine.XR.ARFoundation.ARRaycastManager value) : base(value) { }
	}
}