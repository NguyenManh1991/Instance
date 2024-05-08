using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //[SerializeField] Material color;
    [SerializeField] GameObject player;

    private void Start()
    {
       
    }
    public void SetColor()
    {

        var player1 =
               player.GetComponent<Renderer>();
        player1.material.SetColor("_Color", Color.blue);
        Debug.Log(player1.material.color);
    }
}
