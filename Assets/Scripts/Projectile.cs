using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 0,1.0f);
        transform.Translate(Vector3.right * projectileSpeed * Time.deltaTime);
    }
}
