using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadScenee : MonoBehaviour {

    public void Start()
    {
        
    }   

    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
    }
}
