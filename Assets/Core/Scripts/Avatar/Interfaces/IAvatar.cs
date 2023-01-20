using UnityEngine;

public interface IAvatar : ITarget
{
    public int OwnerId { get; }
    public Vector3 Forward { get; }
    public IAvatarStats AvatarStats { get; }
    public Vector3 GetVectorDisplace(Vector3 value);
}
