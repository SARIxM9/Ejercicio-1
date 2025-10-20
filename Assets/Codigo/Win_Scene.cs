using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win_Scene : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadMenu",3);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
