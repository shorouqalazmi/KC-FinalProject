using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class startmenu : MonoBehaviour
{
    public Text playtxt;
int showtxt = 2;

public void PlayText()
{  if (showtxt %2 == 0)
    {
        playtxt.text = " Press sf,es,fe,g's,eger ";
        showtxt +=1;
    }
    else
    {
        playtxt.text = "";
        showtxt +=1;
    }

}
public void NextScene()
{
     SceneManager.LoadScene(1);
}

}
