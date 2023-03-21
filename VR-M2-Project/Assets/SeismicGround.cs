using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
public float magnitude = 0.1f; // Magnitude de la secousse
public float duration = 1f; // Durée de la secousse
public float frequency = 0.1f; // Fréquence de la secousse
private float timer = 0f;
private Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
      originalPosition = transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
    if (timer < duration) {
    float x = originalPosition.x + Mathf.Sin(Time.time * frequency) * magnitude;
    float z = originalPosition.z + Mathf.Cos(Time.time * frequency) * magnitude;
    transform.position = new Vector3(x, originalPosition.y, z);
    timer += Time.deltaTime;
} else {
    transform.position = originalPosition;
}  
    }
}
