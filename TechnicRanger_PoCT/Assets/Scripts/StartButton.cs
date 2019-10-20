using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Whitebox");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadA(string Whitebox)
    {
        Debug.Log("Whitebox to load: " + Whitebox);
        SceneManager.LoadScene(Whitebox);
    }
}

