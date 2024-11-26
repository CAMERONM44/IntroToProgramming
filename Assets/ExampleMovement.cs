using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Require Component
[RequireComponent(typeof(CharacterController))]
public class ExampleMovement : MonoBehaviour
{
    //moveDirection
    [SerializeField] private Vector3 _moveDirection;
    //moveSpeed
    [SerializeField] private float _moveSpeed;
    //crouchSpeed,walkSpeed, runSpeed
    [SerializeField] private float _crouchSpeed = 2.5f, _walkSpeed = 5, _runSpeed = 10;
    //stamina
    [SerializeField] private float _stamina = 100;
    //drainRate
    [SerializeField] private float _drainRate = 5;
    //recoveryDelay
    [SerializeField] private float _recoverDelay = 2;
    //recoverRate
    [SerializeField] private float _recoverRate = 7;
    //jumpHeight
    [SerializeField] private float _jumpHeight = 8;
    //gravity
    [SerializeField] private float _gravity = 20;
    //characterController
    [SerializeField] private CharacterController _characterController;

    private void Start()
    {
        _characterController = this.GetComponent<CharacterController>();
    }

    private void Update()
    {
        ControlSpeed();
        MovePlayer();
    }

    void ControlStamina()
    {
        //when we are pressing the sprint button and on the ground
        if (true)
        {
            //if its not empty
            if (true)
            {
                //drain stamina

            }
        }

    }
    void ControlSpeed()
    {

    }
    void MovePlayer()
    {

    }
}
