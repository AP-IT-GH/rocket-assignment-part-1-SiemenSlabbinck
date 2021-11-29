using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{
	void OnTriggerEnter(Collider collision)  
	{
		SceneManager.LoadScene("Level2");
	}
}