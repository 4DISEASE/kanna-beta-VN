using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class SpeakerNames : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    // Start is called before the first frame update
    public void Awake()
    {
        dialogueRunner.AddCommandHandler("speakerEnd", NameEnd);
        dialogueRunner.AddCommandHandler("speakerUnknown", NameUnknown);
        dialogueRunner.AddCommandHandler("speakerKanna", NameKanna);
        dialogueRunner.AddCommandHandler("speakerThink", NameThink);
        dialogueRunner.AddCommandHandler("speakerFrag", NameFrag);

    }

    public Text nameText;
    private void NameEnd(string[] parameters)
    {
        nameText.text = "End";
    }
    private void NameUnknown(string[] parameters)
    {
        nameText.text = "?????";
    }

    private void NameKanna(string[] parameters)
    {
        nameText.text = "Kanna";
    }

    private void NameThink(string[] parameters)
    {
        nameText.text = "  ";
    }

    private void NameFrag(string[] parameters)
    {
        nameText.text = "Fragmentor";
    }

}
