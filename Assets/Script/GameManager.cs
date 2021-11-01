using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int Score = 0;
    public GameObject WinText;
    public GameObject RestartButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScoreUp()
    {
        Score++;
        if (Score >= 4)
        {
            Win();
        }
    }
    public void Win()
    {
        WinText.SetActive(true);
        RestartButton.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
