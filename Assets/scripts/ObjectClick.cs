using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn;
using Yarn.Unity;

public class ObjectClick : MonoBehaviour
    
{
    public string objectNode;
    public string characterName = "";

    SpriteRenderer kannabed;
    void Start()
    {
        kannabed = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnMouseEnter()
    {
        kannabed.color = new Color(200.0f/255.0f, 200.0f / 255.0f, 200.0f / 255.0f, 1);
    }

    private void OnMouseExit()
    {
        kannabed.color = new Color(1,1,1, 0);
    }

    private void OnMouseDown()
    {

        kannabed.color = new Color(1, 1, 1, 0);
        FindObjectOfType<DialogueRunner>().StartDialogue(objectNode);
    }

    private void OnMouseUp()
    {
        
    }
}
