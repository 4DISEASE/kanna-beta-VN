using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class SceneSwitcher : MonoBehaviour


{
    public DialogueRunner dialogueRunner;



    public void Awake()
    {
        dialogueRunner.AddCommandHandler("sceneswitch", SceneSwitch);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SceneSwitch(string[] parameters)
    {
        string sceneTitle = parameters[0];
        SceneManager.LoadScene(sceneName: sceneTitle);
    }



    }

