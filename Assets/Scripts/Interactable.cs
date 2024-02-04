using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //Message affiché au joueur quand on regarde un objet interatible
    public string promptMessage;

    //Cette fonction va être appelée par notre joueur.
    public void BaseInteract() 
    {
        Interact(); 
    }
    protected virtual void Interact()
    {
        //Il n'y a pas de code écrit dans cette fonction
        //C'est une fonction template qui peut être overridde par les subclasses
    }
}
