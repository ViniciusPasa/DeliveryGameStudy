using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] public float steerS = 0.35f;
    [SerializeField] public float moveS = 20f;
    [SerializeField] public float boostMove = 30f;
    [SerializeField] public float slowMove = 15f;
    [SerializeField] public float moveF = 20f;
    public float boostDuration = 3f;
    public float destroyDelay = 0.5f;                           
    

    // Update is called once per frame
    void Update()
    {
         float steerAmount = Input.GetAxis("Horizontal") * steerS * Time.deltaTime;
         float moveAmount = Input.GetAxis("Vertical") * moveS * Time.deltaTime;
         
         transform.Rotate(0, 0, -steerAmount);
         transform.Translate(0, moveAmount, 0);


         void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost")
        {
            Debug.Log("foi!");
            moveS = 30f;
            Destroy(other.gameObject, destroyDelay);
            StartCoroutine(boostDuration());
        }
    }
         
    }
}
