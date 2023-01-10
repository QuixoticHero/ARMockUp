using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class IAvatarStatsReference : BaseReference<IAvatarStats, IAvatarStatsVariable>
	{
	    public IAvatarStatsReference() : base() { }
	    public IAvatarStatsReference(IAvatarStats value) : base(value) { }
	}
}