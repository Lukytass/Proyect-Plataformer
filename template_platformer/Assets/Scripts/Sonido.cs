
using System;
using UnityEngine;

[System.Serializable]
public class Sonido:MonoBehaviour
{
    public string Nombre;
    public AudioClip ClipSonido;

    [Range(0f, 1f)]
    public float Volumen;

    [Range(0f, 1f)]
    public float pitch;

    public bool repetir;

    [HideInInspector]
    public AudioSource FuenteAudio;
}
