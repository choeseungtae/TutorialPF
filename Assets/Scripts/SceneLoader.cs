using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int SceneIndex = 1;
   public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
