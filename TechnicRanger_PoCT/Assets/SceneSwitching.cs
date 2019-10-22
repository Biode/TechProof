using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitching : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("TechProof"));
        }

        if (Input.GetKeyDown("2"))
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Skateboard"));
        }

        if (Input.GetKeyDown("3"))
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Whitebox"));
        }
    }
}
