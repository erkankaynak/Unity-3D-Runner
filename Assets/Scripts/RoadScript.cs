using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadScript : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Invoke("MoveRoad", .1f);
        }
    }
    void MoveRoad()
    {
        transform.position += Vector3.forward * 300;
    }
}