using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI MyscoreText;
    private int ScoreNum;
    public AudioSource tickSource;

    // Start is called before the first frame update
    void Start()
    {
        tickSource = GetComponent<AudioSource>();
        ScoreNum = 0;
        MyscoreText.text = "Score : " + ScoreNum;
    }

     void Update()
    {
         if(ScoreNum == 4)
         {
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
            
         }
    }  
 private void OnTriggerEnter2D(Collider2D Score)
 {
     if(Score.tag =="london")
     {
         tickSource.Play();
     }
     if(Score.tag =="london")
     {
         ScoreNum += 1;
         Destroy(Score.gameObject);
         MyscoreText.text = "Score" + ScoreNum;
     }
     if(Score.tag =="enemy")
     {
         if(ScoreNum==0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         else
         {
             ScoreNum -= 1;
           Destroy(Score.gameObject);
           MyscoreText.text = "Score" + ScoreNum;
         }
     }
 }
} 
