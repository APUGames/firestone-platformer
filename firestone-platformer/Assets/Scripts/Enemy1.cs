using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    Rigidbody2D enemyCharacter;

    [SerializeField] private float moveSpeed = 1.0f;
    bool IsGoingUp()
    {
        return transform.localScale.y > 0;
    }


    // Start is called before the first frame update
    void Start()
    {
        enemyCharacter = GetComponent<Rigidbody2D>();   

    }

    // Update is called once per frame
    void Update()
    {
        if (IsGoingUp())
        {
            enemyCharacter.velocity = new Vector2(moveSpeed, 0);

        }
        else
        {
            enemyCharacter.velocity = new Vector2(-moveSpeed, 0);

        }

    }
    private void OnTriggerExit2D (Collider2D collision)
    {
      //reverse scale of y axis
     // transform.localScale = new Vector2( -(Mathf.Sign(enemyCharacter.velocity.y)), 1f);//can we make it so that the sprite does not flip?

    }

}
