using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //Message affich� au joueur quand on regarde un objet interatible
    public string promptMessage;

    //Cette fonction va �tre appel�e par notre joueur.
    public void BaseInteract() 
    {
        Interact(); 
    }
    protected virtual void Interact()
    {
        //Il n'y a pas de code �crit dans cette fonction
        //C'est une fonction template qui peut �tre overridde par les subclasses
    }
}
