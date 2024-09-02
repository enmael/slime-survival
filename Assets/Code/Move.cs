using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
 public Vector2 inputV2;

   public float spped;

    Rigidbody2D rigidbody2D;
    SpriteRenderer spriteRenderer;
   void Awake() 
   {
        rigidbody2D = GetComponent<Rigidbody2D>();       
        spriteRenderer = GetComponent<SpriteRenderer>();
   }

    void Update()
    {
        inputV2.x = Input.GetAxisRaw("Horizontal");
        inputV2.y = Input.GetAxisRaw ("Vertical");
    }

    void FixedUpdate()
    {
        // rigidbody2D.AddForce(inputV2);
        // rigidbody2D.velocity =inputV2;
        Vector2 newVector2 =inputV2.normalized * spped * Time.fixedDeltaTime;

        rigidbody2D.MovePosition(rigidbody2D.position+ newVector2); 
    }

    void LateUpdate() 
    {
        if(inputV2.x != 0)
        {
            spriteRenderer.flipX = inputV2.x < 0;
        }   
    }
}
