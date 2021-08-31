using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Camera camera;
    private Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        camera.transform.position = this.transform.position + offset;
    }
}
