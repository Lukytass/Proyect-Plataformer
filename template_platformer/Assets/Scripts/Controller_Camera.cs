using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Camera : MonoBehaviour
{
    public List<GameObject> players;
    private Camera _camera;
    public float dampTime = 0.15f;
    public float smoothTime = 2f;
    public float zoomvalue;
    private Vector3 velocity = Vector3.zero;


    void Start()
    {
        _camera = GetComponent<Camera>();


        GestorDeAudio.instancia.ReproducirSonido("BackInBlack");
        GestorDeAudio.instancia.PausarSonido("RightHere");
        GestorDeAudio.instancia.PausarSonido("Garrix");
        GestorDeAudio.instancia.PausarSonido("ColdHeart");
        GestorDeAudio.instancia.PausarSonido("Clasic");
    }

    void LateUpdate()
    {
        if (players[GameManager.actualPlayer] != null)
        {
            Vector3 point = _camera.WorldToViewportPoint(players[GameManager.actualPlayer].transform.position);
            Vector3 delta = players[GameManager.actualPlayer].transform.position - _camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }
        if (Input.GetKeyDown("1"))
        {
            GestorDeAudio.instancia.ReproducirSonido("BackInBlack");
            GestorDeAudio.instancia.PausarSonido("RightHere");
            GestorDeAudio.instancia.PausarSonido("Garrix");
            GestorDeAudio.instancia.PausarSonido("Clasic");
            GestorDeAudio.instancia.PausarSonido("ColdHeart");
        }
        if (Input.GetKeyDown("2"))
        {
            GestorDeAudio.instancia.PausarSonido("BackInBlack");
            GestorDeAudio.instancia.ReproducirSonido("RightHere");
            GestorDeAudio.instancia.PausarSonido("Garrix");
            GestorDeAudio.instancia.PausarSonido("Clasic"); 
            GestorDeAudio.instancia.PausarSonido("ColdHeart");
        }
        if (Input.GetKeyDown("3"))
        {
            GestorDeAudio.instancia.ReproducirSonido("Garrix");
            GestorDeAudio.instancia.PausarSonido("RightHere");
            GestorDeAudio.instancia.PausarSonido("BackInBlack");
            GestorDeAudio.instancia.PausarSonido("Clasic");
            GestorDeAudio.instancia.PausarSonido("ColdHeart");
        }
        if (Input.GetKeyDown("4"))
        {
            GestorDeAudio.instancia.PausarSonido("Garrix");
            GestorDeAudio.instancia.PausarSonido("RightHere");
            GestorDeAudio.instancia.PausarSonido("BackInBlack");
            GestorDeAudio.instancia.ReproducirSonido("Clasic");
            GestorDeAudio.instancia.PausarSonido("ColdHeart");
        }

        if (Input.GetKeyDown("5"))
        {
            GestorDeAudio.instancia.PausarSonido("Garrix");
            GestorDeAudio.instancia.PausarSonido("RightHere");
            GestorDeAudio.instancia.PausarSonido("BackInBlack");
            GestorDeAudio.instancia.PausarSonido("Clasic");
            GestorDeAudio.instancia.ReproducirSonido("ColdHeart");
        }
    }
   
}
