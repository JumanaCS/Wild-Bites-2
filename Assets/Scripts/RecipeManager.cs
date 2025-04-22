using System.Collections.Generic;
using UnityEngine;

public class RecipeManager : MonoBehaviour
{
    public List<GameObject> ingredients; 
    public int currentStep = 0;

    void Update()
    {
        foreach (var piece in ingredients)
        {
            SpriteRenderer sr = piece.gameObject.GetComponent<SpriteRenderer>();
            Collider2D col = piece.gameObject.GetComponent<Collider2D>();

            
        }
    }
}
