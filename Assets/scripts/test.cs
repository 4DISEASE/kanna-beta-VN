using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class test : MonoBehaviour
{
    public class CustomWaitCommand : MonoBehaviour
    {

        // Drag and drop your Dialogue Runner into this variable.
        public DialogueRunner dialogueRunner;

        public void Awake()
        {

            // Create a new command called 'custom_wait', which waits for one second.
            dialogueRunner.AddCommandHandler(
                "custom_wait",
                CustomWait
            );
        }

        // The method that gets called when '<<custom_wait>>' is run.
        private void CustomWait(string[] parameters, System.Action onComplete)
        {

            // Start a coroutine that waits for one second:
            StartCoroutine(DoWait(onComplete));

            // Because this method takes a System.Action parameter, it's a blocking
            // command. Yarn Spinner will wait until onComplete is called.
        }

        private IEnumerator DoWait(System.Action onComplete)
        {

            // Wait for 1 second
            yield return new WaitForSeconds(1);

            // Call the completion handler
            onComplete();

            // Yarn Spinner will now continue running!
        }
    }
}
