using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DummyCharacterController : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 200f;
    [SerializeField] private bool _verbose = false;
    Rigidbody2D _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }
    public void OnJump(InputValue value)
    {
        _rigidBody.AddForce(new Vector2(0, _jumpForce));
    }

    public void OnFire(InputValue value)
    {
        if(_verbose) print("Called Fire, Dummy Character Controller");
    }
}
