using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class ITargetReference : BaseReference<ITarget, ITargetVariable>
	{
	    public ITargetReference() : base() { }
	    public ITargetReference(ITarget value) : base(value) { }
	}
}