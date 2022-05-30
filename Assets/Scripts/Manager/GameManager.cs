using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }

    public GameObject statue;

    [Header("Scripts")] 
    public StatueController statueController;
    public UIController uıController;

    [Header("Bool")] 
    public bool isStart;
    public bool isDone;

    private void Awake()
    {
        Instance = this;
    }

    public void GameStart()
    {
        isStart = true;
        uıController.startBtn.SetActive(false);
    }

    public void GameRestart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
