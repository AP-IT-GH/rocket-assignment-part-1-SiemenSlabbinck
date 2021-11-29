using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisappearScript : MonoBehaviour
{
    public int points = 0;
    void OnTriggerEnter(Collider other)
    {
        ScoreManager.instance.AddPoint();
        Destroy(gameObject);
    }
}
