using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    public GameObject projectTile, projectileParent;


   void ProjectileFire()
    {
        GameObject tempProjetile = Instantiate(projectTile) as GameObject;
        tempProjetile.transform.position=projectileParent.transform.position;
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}
