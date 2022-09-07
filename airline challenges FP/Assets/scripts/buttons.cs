using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
	public void next(int index)
	{
		SceneManager.LoadScene(index);
	}
 }
