using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shedder : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
