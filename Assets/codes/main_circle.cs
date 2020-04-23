using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_circle : MonoBehaviour
{
    public GameObject small_circle;
    GameObject game_manager;

    void Start()
    {
        game_manager = GameObject.FindGameObjectWithTag("game_manager_TAG");
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            small_circle_create();
        }
    }

    void small_circle_create()
    {
        Instantiate(small_circle, transform.position, transform.rotation);
        game_manager.GetComponent<game_manager_code>().small_circle_show_text();
    }

}
