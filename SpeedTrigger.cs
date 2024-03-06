using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f;
    void OnTriggerEnter(Collider other)
    {
        //Увеличить скорость бега
        other.GetComponent<FirstPersonMovement>().speed *= speedFactor;
    }
    void OnTriggerExit(Collider other)
    {
        //Снизить скорость бега
        other.GetComponent<FirstPersonMovement>().speed /= speedFactor;
    }
}
