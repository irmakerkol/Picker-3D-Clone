using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetController : MonoBehaviour
{
    public float movementSpeed;
    public float horizontalSpeed;

    private Vector3 _lastPosition = Vector3.zero;
    private Vector3 _delta = Vector3.zero;

    private CharacterController controller;


    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }


    void Update()
    {
        if(GameManager.instance.currentState == GameManager.GameState.InGame)
        {
            RunMagnet();
        }
        else if(GameManager.instance.currentState == GameManager.GameState.End)
        {
            StopMagnet();
        }
        
    }


    public void RunMagnet()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _lastPosition = Input.mousePosition;
        }

        else if (Input.GetMouseButton(0))
        {
            _delta = Input.mousePosition - _lastPosition;
            _lastPosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            _delta = Vector3.zero;
        }

        controller.Move(new Vector3(_delta.x * horizontalSpeed * Time.deltaTime, 0, movementSpeed * Time.deltaTime));

    }

    public void StopMagnet()
    {
        movementSpeed = 0f;
        horizontalSpeed = 0f;
    }
}
