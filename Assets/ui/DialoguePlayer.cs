using TMPro;
using UnityEngine;

public class DialoguePlayer : MonoBehaviour
{

    public DialogueAsset dialogueAsset; //variable faite pour afficher un dialogue
    public TMP_Text dialogueText; // voir ce qui affichera l etext plus tard sur unity
    public GameObject dialogueBox;  

    public int dialogueLineIndex;// index pour quel ligne de dialogue 
    //dialogue line index indique le numéro de ligne de dialogue 
    private void Start() 
    {
        dialogueText.text = dialogueAsset.dialogue[0]; // lui dire d'afficher le texte 0 (celui où j'ai écrit prout at first
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) //getkeydown : qd pressé / getkeyup : laché / si getkey sans autre : effectue l'action tant que maintenu
        {
            dialogueLineIndex += 1; //lui ajoute 1 donc passe au dialogue suivant ; ou dialogueLineIndex = dialogueLineIndex +1 ; oudialogueLineIndex++

            if (dialogueLineIndex < dialogueAsset.dialogue.Length) // si index inférieur à taille de la liste
            {
                dialogueText.text = dialogueAsset.dialogue[dialogueLineIndex]; //c'est que ya encore un dialogue à afficher 
            }
            else
            {
                dialogueBox.gameObject.SetActive(false); //setactive false pour désactiver qq chose ; pour désactiver l'objet complet : game object 
            }
        }
    }
}
