using UnityEngine;

public class SpaceObject : DamageGetter, IMover
{
    public Rigidbody _rigidbody;
    public Transform _transform;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();
    }

    public virtual void Move()
    {

    }
}