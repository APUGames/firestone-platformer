using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    [SerializeField] private AudioClip crystalSFX;//tag objects for different sound effects

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint (crystalSFX, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
