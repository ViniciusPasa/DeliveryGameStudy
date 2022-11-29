using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
     
    [SerializeField] Color32 hasPackageColor = new Color32(255, 255, 255, 255);
    [SerializeField] Color32 hasNotPackageColor = new Color32(0,0,0,255);
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPack;
    float moveS = 20f;
    float boostMove = 30f;
    public float moveF = 20f;
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && hasPack == false)
        {
            Debug.Log("Package Picked!");
            hasPack = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
            
        }
        
        if(other.tag == "Client" && hasPack)
        {
            Debug.Log("Package Delivered!");
            hasPack = false;
            spriteRenderer.color = hasNotPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }

        //if(other.tag == "Boost")
        //{
          //  Debug.Log("foi");
        //}
    }
}
