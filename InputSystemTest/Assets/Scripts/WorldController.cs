using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WorldController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 50f;
    [SerializeField] private bool _verbose = false;
    private Vector2 _movement;
    private Transform _transform;

    public void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    public void FixedUpdate()
    {
        _transform.Rotate(0, 0, _movement.x * _rotationSpeed * Time.deltaTime);
    }

    public void OnMove(InputValue value)
    {
        if(_verbose) print("Moving?: " + value.Get<Vector2>());
        Vector2 inputVector = value.Get<Vector2>();
        _movement = new Vector2(inputVector.x, inputVector.y).normalized;
    }
}
