using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public GameObject asteroid;
    float randomX = 2.68f;
    float randomZ = 5f;

    static int score;
    public Text scoreText;
    public Text GameOverText;
    bool IsGameOver;
    bool IsRestart;
    void Start()
    {
        score =0;
        IsGameOver = false;
        IsRestart = false;
        StartCoroutine(Olustur());
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && IsRestart)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    IEnumerator Olustur()
    {
        yield return new WaitForSeconds(3);
        while(true)
        {
            for(int i =0; i<3 ; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomX,randomX), -2.51f, randomZ);
                Instantiate (asteroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(0.9f);
            }
            yield return new WaitForSeconds(0.9f);

            if (IsGameOver)
            {
                IsRestart = true;
                break;
            }
        }
    }

    public void ScoreArttir(int _score)
    {
        score += _score;
        scoreText.text = "Score : " + score;
        Debug.Log(score);
    }

    public void OyunBitti()
    {
        IsGameOver = true;
        GameOverText.text = "Oyuna tekrar başlamak istiyorsanız R'ye basın.";
    }
}

