using UnityEngine;

public interface IAvatar 
{
    public int OwnerId { get; }
    public Vector3 Position { get; }
    public Vector3 Forward { get; }
    public IAvatarStats AvatarStats { get; }
    public Vector3 GetVectorDisplace(Vector3 value);
}
