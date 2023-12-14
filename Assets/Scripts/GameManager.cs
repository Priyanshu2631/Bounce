using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score=0;
    public TextMeshProUGUI Score;
    public GameObject gameStartUI;

    private void Awake(){
        instance=this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameStart(){
        gameStartUI.SetActive(false);
        Score.gameObject.SetActive(true);
    }
    public void Restart(){
        SceneManager.LoadScene("Game");
    }
    public void ScoreUp(){
        score++;
        Score.text=score.ToString();
    }
}
