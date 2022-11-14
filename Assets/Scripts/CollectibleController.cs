using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleController : MonoBehaviour
{
    private bool isCollidingMagnet = false;

    private float movementSpeed = 10f;


    void Update()
    {
        if (isCollidingMagnet)
        {
            transform.position = new Vector3(transform.position.x + 10 * Time.deltaTime, transform.position.y, transform.position.z + 10 * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Magnet")
        {
            isCollidingMagnet = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
 
        if (other.gameObject.tag == "Magnet")
        {
            isCollidingMagnet = false;
        }
    }




}
