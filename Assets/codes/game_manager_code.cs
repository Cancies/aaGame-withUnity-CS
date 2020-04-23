using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game_manager_code : MonoBehaviour
{
    GameObject rotate_circle;
    GameObject main_circle;
    public Animator animator;
    public Text rotate_circle_level;
    public Text one;
    public Text two;
    public Text three;
    public int howmany_small_circle;
    bool control=true;
    void Start()
    {
        PlayerPrefs.SetInt("save",int.Parse(SceneManager.GetActiveScene().name));
        
        rotate_circle = GameObject.FindGameObjectWithTag("rotate_circle_TAG");
        main_circle = GameObject.FindGameObjectWithTag("main_circle_TAG");
        rotate_circle_level.text = SceneManager.GetActiveScene().name;

        if (howmany_small_circle<2)
        {
            one.text = howmany_small_circle + "";
            two.text = "";
            three.text = "";
        }
        else if (howmany_small_circle<3)
        {
            one.text = howmany_small_circle + "";
            two.text = (howmany_small_circle-1) + "";
            three.text = "";
        }
        else
        {
            one.text = howmany_small_circle + "";
            two.text = (howmany_small_circle - 1) + "";
            three.text = (howmany_small_circle - 2) + "";
        }
    }

    public void small_circle_show_text()
    {
        howmany_small_circle--;
        if (howmany_small_circle < 2)
        {
            one.text = howmany_small_circle + "";
            two.text = "";
            three.text = "";
        }
        else if (howmany_small_circle < 3)
        {
            one.text = howmany_small_circle + "";
            two.text = (howmany_small_circle - 1) + "";
            three.text = "";
        }
        else
        {
            one.text = howmany_small_circle + "";
            two.text = (howmany_small_circle - 1) + "";
            three.text = (howmany_small_circle - 2) + "";
        }
        if (howmany_small_circle==0)
        {
            StartCoroutine(new_level());
        }
    }
    
    IEnumerator new_level()
    {
        rotate_circle.GetComponent<rotate>().enabled = false;
        main_circle.GetComponent<main_circle>().enabled = false;
        yield return new WaitForSeconds(1);
        if (control)
        {
            animator.SetTrigger("new_level");
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);
        }
    }
      
    public void game_over()
    {
        StartCoroutine(calling_method());
    }     

    IEnumerator calling_method()
    {
        rotate_circle.GetComponent<rotate>().enabled = false;
        main_circle.GetComponent<main_circle>().enabled = false;
        animator.SetTrigger("game_over");
        control = false;

        yield return new WaitForSeconds(2);     //waiting a second

        
        SceneManager.LoadScene("menu");
    }
}
    