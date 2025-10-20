using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource audioSource;
    public TMP_Text textoNumeroItems;
    private int itemsNumber;

    public TMP_Text textoTotalNumbers;
    private int totalNumbers;
    void Start()
    {
        totalNumbers = transform.childCount;
        textoTotalNumbers.text = totalNumbers.ToString();
    }

    void Update()
    {
        if (transform.childCount <= 0)
        {
            Debug.Log("Winner");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void SumarItems()
    {
        audioSource.Play();
        itemsNumber++;
        textoNumeroItems.text = itemsNumber.ToString();
    }
}
