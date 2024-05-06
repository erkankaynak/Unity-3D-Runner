using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtSpeed;
    public GameObject panelGameOver;

    public float playerSpeed;
    public float playerSpeedIncValue;
    private void Start()
    {
        playerSpeed = 10f;
        SpeedUp();
    }
    public void SpeedUp()
    {
        if (playerSpeed < 80)
        {
            playerSpeed += playerSpeedIncValue;
            SetSpeedText(playerSpeed);
            Invoke("SpeedUp", 2f);
        }

    }
    public void SetScoreText(int score)
    {
        txtScore.SetText(score.ToString() + "m");
    }
    public void SetSpeedText(float speed)
    {
        txtSpeed.SetText("Speed: " + speed.ToString());
    }
    public void GameOver()
    {
        panelGameOver.SetActive(true);
        Time.timeScale = 0;

    }
    public void PlayAgain()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
}
