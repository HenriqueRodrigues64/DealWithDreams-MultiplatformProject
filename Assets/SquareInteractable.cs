using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SquareInteractable : MonoBehaviour, IInteractable
{
    public bool buttonActivated = false;
    private SpriteRenderer spriteRenderer;

    private void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Interact(GameObject Instigator)
    {
        Debug.Log("i like trains");
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {     

        //Activate button
        if(buttonActivated == false){
            SetColor( Color.red);
            if(collision.gameObject.name == "Dreamer"){
                buttonActivated = true;
            }            
        }

        //Deactivate button 
        if(buttonActivated == true){
            SetColor( Color.green);
        }

        if(collision.gameObject.name != "Dreamer"){
                buttonActivated = false;
        }  
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (buttonActivated == true && collision.gameObject.name == "Dreamer")
        {
            buttonActivated = false;
            SetColor(Color.red);
        }
    }


    private void SetColor(Color color)
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.color = color;
        }
    }
}
