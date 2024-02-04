using UnityEngine;

public interface IMovable
{
    bool HasReachedDestination();
    void SetDestination(Transform destinationPoint);
}