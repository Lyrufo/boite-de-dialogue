using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DialogueAsset : ScriptableObject //scriptable object conteneur de donn�es (m�me pour des texture, des assets etc)
{
    [TextArea (3,6)] //min et max de lignes [] pour liste
    public string [] dialogue; //variable champ texte appel� dialogue 

}
