using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UIElements;

public class animeAttack : MonoBehaviour
{
    private Transform Player;
    private anime anime;
    public float attackRange = 10f;
    public Material defaultMaterial;
    public Material alterMaterial;
    public Renderer rend;
    private bool Foundplayer;
    // Start is called before the first frame update
    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        anime = GetComponent<anime>();
        rend = GetComponent<Renderer>(); 
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.position) <= attackRange)
        {
            rend.sharedMaterial = alterMaterial;
            anime.badguy.SetDestination(Player.position);
            Foundplayer = true;
        }
        else if (Foundplayer)
        { 
            rend.sharedMaterial = defaultMaterial;
            anime.newLocation();
            Foundplayer = false;
        }
    }
}
