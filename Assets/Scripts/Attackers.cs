using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackers : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(-1f, 2f)]
    public float lizardWalkSpeed;
    Animator lizardAnim;
    SpriteRenderer lizardSprite;
    void Start()
    {
        lizardAnim = GetComponent<Animator>();
     //  Rigidbody2D rb =AddComponent<Rigidbody2D>();
        lizardSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lizardWalkSpeed > 0)
        {
            lizardSprite.flipX = false;
            lizardAnim.SetFloat("IsWalking", lizardWalkSpeed);
            transform.Translate(Vector3.left * lizardWalkSpeed * Time.deltaTime);

        }


        if (lizardWalkSpeed < 0)
        {
            lizardSprite.flipX = true;
            lizardAnim.SetFloat("IsWalking", lizardWalkSpeed);
            transform.Translate(Vector3.left * lizardWalkSpeed * Time.deltaTime);
          
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log( "triggered with" +name );
    }
}
