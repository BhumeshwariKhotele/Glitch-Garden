using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackers : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(-1f, 2f)]
    public float lizardWalkSpeed;
    Animator lizardAnim; 

    void Start()
    {
        lizardAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(lizardWalkSpeed > 0 && lizardWalkSpeed <= 2f)
        {
            lizardAnim.SetFloat("IsWalking", lizardWalkSpeed);
            transform.Translate(Vector3.left * lizardWalkSpeed * Time.deltaTime);
          
        }

        if (lizardWalkSpeed == 0 )
        {
           
        }
    }
}
