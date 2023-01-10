using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class IAvatarReference : BaseReference<IAvatar, IAvatarVariable>
	{
	    public IAvatarReference() : base() { }
	    public IAvatarReference(IAvatar value) : base(value) { }
	}
}