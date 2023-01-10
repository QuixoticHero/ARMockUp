using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class CameraReference : BaseReference<Camera, CameraVariable>
	{
	    public CameraReference() : base() { }
	    public CameraReference(Camera value) : base(value) { }
	}
}