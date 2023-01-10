namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class TransformReference : BaseReference<UnityEngine.Transform, TransformVariable>
	{
	    public TransformReference() : base() { }
	    public TransformReference(UnityEngine.Transform value) : base(value) { }
	}
}