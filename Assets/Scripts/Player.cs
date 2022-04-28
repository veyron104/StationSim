using UnityEngine;

public class Player : SpaceObject
{
    float _rotation;
    public float Speed;

    public override void Move()
    {
        _rigidbody.AddForce(transform.forward * EnginePower());
        _rotation += Input.GetAxis("Horizontal");
        _transform.rotation = Quaternion.Euler(0, _rotation, 0);
    }

    float EnginePower()
    {
        if (_rigidbody.velocity.magnitude > 0) return Input.GetAxis("Vertical") * (Speed - Mathf.Clamp((Vector3.Cross(_rigidbody.velocity, transform.forward) / _rigidbody.velocity.magnitude).magnitude, 0, Speed));
        else return Input.GetAxis("Vertical") * Speed;
    }
}