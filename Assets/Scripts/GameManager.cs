using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int scoreToReach;
    public GameObject CanvasMenu;
    public  int PlayerScoreL = 0;
    public  int PlayerScoreR = 0;

    //Buat UI Text
    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;
    
    public static GameManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        //Mengisikan nilai integer PlayerScore ke UI
        CanvasMenu.SetActive(false);
        txtPlayerScoreL.text = PlayerScoreL.ToString();
        txtPlayerScoreR.text = PlayerScoreR.ToString();
    }

    public void Pause()
    {
        CanvasMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void UnPause()
    {
        Time.timeScale = 1f;
        CanvasMenu.SetActive(false);
    }

    public void ScoreCheck()
    {
        if (PlayerScoreL == scoreToReach || PlayerScoreR == scoreToReach)
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    //Method penyeleksi untuk menambah score
    public void Score(string wallID)
    {
        if (wallID == "Batas Kiri")
        {
            PlayerScoreR = PlayerScoreR + 1; //Menambah score
            txtPlayerScoreR.text = PlayerScoreR.ToString(); //Mengisikan nilai integer PlayerScore ke UI
            ScoreCheck();
        }
        else
        {
            PlayerScoreL = PlayerScoreL + 1;
            txtPlayerScoreL.text = PlayerScoreL.ToString();
            ScoreCheck();
        }
    }

    

}