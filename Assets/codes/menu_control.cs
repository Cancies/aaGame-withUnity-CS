using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_control : MonoBehaviour
{
    void Start()
    {
       // PlayerPrefs.DeleteAll();     DELETE TO SAVE LEVELS
    }

    public void run_game()
    {
        int save_count = PlayerPrefs.GetInt("save");

        if (save_count==0)
        {
            SceneManager.LoadScene(save_count + 1);
        }
        else
        {
            SceneManager.LoadScene(save_count);
        }
    }

    public void exit_game()
    {
        Application.Quit();
    }
}
 