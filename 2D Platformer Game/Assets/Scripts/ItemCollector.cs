using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour

{ 
    private int watermelons = 0;
    [SerializeField] private AudioSource collectionSoundEffect;
    [SerializeField] private Text watermelonsText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Watermelon"))
       {
        collectionSoundEffect.Play();
        Destroy(collision.gameObject);
        watermelons ++;
        watermelonsText.text = "Watermelons:" + watermelons;
        
       }
    
    }

}
