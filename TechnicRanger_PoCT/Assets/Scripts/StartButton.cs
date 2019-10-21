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

  //  public static void LoadScene(string TechProof, SceneManagement.LoadSceneMode mode = LoadSceneMode.Single);
    public void LoadA(string TechProof)
    {
        Debug.Log("Whitebox to load: " + TechProof);
        SceneManager.LoadScene(TechProof);
    }
}

