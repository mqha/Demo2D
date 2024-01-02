using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleFlow : MonoBehaviour
{

    public GameObject gameOverUI;
    public PlayerHealth playerHealth;
    public GameObject bgMusic;

    public GameObject gameWinUI;

    void Start()
    {
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);
        playerHealth.onDead += OnGameOver;
    }

    private void Update()
    {
        if(EnemyHealth.LivingEnemeCount <= 0)
        {
            OnGameWin();
        }
    }

    private void OnGameWin()
    {
        gameWinUI.SetActive(true);
        bgMusic.SetActive(false);
        playerHealth.gameObject.SetActive(false);
    }

    private void OnGameOver()
    {
        gameOverUI.SetActive(true);
        bgMusic.SetActive(false);
    }

    public void ReturnToMainMenu() => SceneManager.LoadScene("MainMenu");
}
