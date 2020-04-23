using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class small_circle_code : MonoBehaviour
{
    Rigidbody2D physic;
    public float speed;
    bool control=false;
    GameObject game_manager;
    void Start()
    {
        physic = GetComponent<Rigidbody2D>();
        game_manager = GameObject.FindGameObjectWithTag("game_manager_TAG");
    }

    
    void FixedUpdate()
    {
        if (!control)
        {
            physic.MovePosition(physic.position + Vector2.up * speed * Time.deltaTime);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "rotate_circle_TAG")
        {
            transform.SetParent(col.transform);
            control = true;
            
        }
  
        if (col.tag == "small_circle_TAG" )
        {
            game_manager.GetComponent<game_manager_code>().game_over();
            
            
        }
    }

}
 