using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.WSA.Input;
using Yarn.Unity;

public class AnimationsScript : MonoBehaviour

{
    public DialogueRunner dialogueRunner;
    public Animator fadeAnimator;
    public string sceneName;
    public Animator dialogueBoxAnimator;
    public Animator characterAnimator;

    public void Awake()
    {
        dialogueRunner.AddCommandHandler("screenfadein", ScreenFadeIn);
        dialogueRunner.AddCommandHandler("fastfadein", FastFadeIn);
        dialogueRunner.AddCommandHandler("charfadein", CharFadeIn);

    }

    private void ScreenFadeIn(string[] parameters, System.Action onComplete)
    {
        StartCoroutine(LoadScene());
    }

    private void CharFadeIn(string[] parameters, System.Action onComplete)
    {
        StartCoroutine(CharFadeInCoroutine(onComplete));
    }

    IEnumerator CharFadeInCoroutine(System.Action onComplete)
    {
        characterAnimator.SetTrigger("charfadein");
        yield return new WaitForSeconds(0.5f);
        onComplete();
    }


    private void FastFadeIn(string[] parameters, System.Action onComplete)
    {
        StartCoroutine(FastFadeInCoroutine(onComplete));
        
    }

    IEnumerator LoadScene(){
        fadeAnimator.SetTrigger("fadestart");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(sceneName);
    }

    public IEnumerator FastFadeInCoroutine(System.Action onComplete)
    {
        dialogueBoxAnimator.SetTrigger("fadein");
        yield return new WaitForSeconds(0.5f);
        onComplete();
    }




}
