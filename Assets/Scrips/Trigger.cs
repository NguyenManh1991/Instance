using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] Player player;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger is here");
        Debug.Log(this.transform.position);
        //player.SetColor();
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.SetColor("_Color", Color.green);
    }
    private void OnTriggerExit(Collider other)
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.SetColor("_Color", Color.yellow);
    }
}
