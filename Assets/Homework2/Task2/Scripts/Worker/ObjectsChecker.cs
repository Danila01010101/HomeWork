using System.Linq;
using UnityEngine;

public class ObjectsChecker : MonoBehaviour
{
    private float _checkRadius;

    public void Initialize(float radius) => _checkRadius = radius;

    public bool IsObjectNear<T>()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, _checkRadius);

        bool isObjectFound = colliders.Where(collider => collider.gameObject.GetComponent<T>() != null).Count() > 0;

        return isObjectFound;
    }
}