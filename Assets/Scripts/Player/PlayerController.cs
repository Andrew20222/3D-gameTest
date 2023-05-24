using System;
using UnityEngine;

[RequireComponent(typeof(InputService))]
[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    private const int NUMBER_ZERO = 0;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private InputService _inputService;
    [SerializeField]
    private CharacterController _characterController;
    private float _gravity = -9.81f;
    private float _gravityMultiplier = 3.0f;
    private float _velocity;
    private Vector3 _direction;
    
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _direction = new Vector3(_inputService.InputHorizontal,
            0, _inputService.InputVertical);
        _characterController.Move( _direction * (_speed * Time.deltaTime));
    }
}

