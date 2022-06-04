using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    int levels;
    public Button[] buttons;

    void Start()
    {
//значение 1 (второй аргумент) по дефолту
        levels = PlayerPrefs.GetInt("levels", 1);

        for (int i = 0; i < levels; i++)
        {
            buttons[i].gameObject.SetActive(true);
        }

         for (int i = levels; i < buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(false);
        }
    }

    public void loadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}

