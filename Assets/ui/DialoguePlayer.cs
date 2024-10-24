using TMPro;
using UnityEngine;

public class DialoguePlayer : MonoBehaviour
{

    public DialogueAsset dialogueAsset; //variable faite pour afficher un dialogue
    public TMP_Text dialogueText; // voir ce qui affichera l etext plus tard sur unity
    public GameObject dialogueBox;  

    public int dialogueLineIndex;// index pour quel ligne de dialogue 
    //dialogue line index indique le num�ro de ligne de dialogue 
    private void Start() 
    {
        dialogueText.text = dialogueAsset.dialogue[0]; // lui dire d'afficher le texte 0 (celui o� j'ai �crit prout at first
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) //getkeydown : qd press� / getkeyup : lach� / si getkey sans autre : effectue l'action tant que maintenu
        {
            dialogueLineIndex += 1; //lui ajoute 1 donc passe au dialogue suivant ; ou dialogueLineIndex = dialogueLineIndex +1 ; oudialogueLineIndex++

            if (dialogueLineIndex < dialogueAsset.dialogue.Length) // si index inf�rieur � taille de la liste
            {
                dialogueText.text = dialogueAsset.dialogue[dialogueLineIndex]; //c'est que ya encore un dialogue � afficher 
            }
            else
            {
                dialogueBox.gameObject.SetActive(false); //setactive false pour d�sactiver qq chose ; pour d�sactiver l'objet complet : game object 
            }
        }
    }
}
