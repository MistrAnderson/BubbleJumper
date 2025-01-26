using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        int currScene = SceneManager.GetActiveScene().buildIndex;
        ChangeScene(currScene + 1);
    }

    public void ChangeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
