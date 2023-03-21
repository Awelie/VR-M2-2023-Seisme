using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earthquake : MonoBehaviour
{
    public float magnitude = 1.0f; // La magnitude du tremblement de terre
    public float duration = 1.0f; // La durée du tremblement de terre

    private float timer = 0.0f;
    private Vector3 originalPosition;

    void Start () {
        originalPosition = transform.position; // Position initiale de l'objet
    }
    
    void Update () {
        if (timer < duration) {
            // Calcul de la position de l'objet avec un décalage aléatoire
            Vector3 newPosition = originalPosition + Random.insideUnitSphere * magnitude;
            transform.position = newPosition;

            timer += Time.deltaTime;
        }
        else {
            transform.position = originalPosition; // Retour à la position initiale
            enabled = false; // Désactivation du script
        }
    }
}