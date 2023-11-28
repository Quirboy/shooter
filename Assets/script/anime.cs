using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class anime : MonoBehaviour

{
    public NavMeshAgent badguy;
    public float squarOfMovement = 100f;
    private float xMin;
    private float xMax;
    private float zMin;
    private float zMax;
    private float xPosition;
    private float zPosition;
    private float yPosition;
    public float closeEnough = 2f;


    // Start is called before the first frame update
    void Start()
    {
        xMin = zMin = -squarOfMovement;
        xMax = zMax = -squarOfMovement;
        newLocation();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, new Vector3(xPosition, yPosition, zPosition)) <= closeEnough)
        {
            newLocation();
        }
    }

    public void newLocation()
    {
        yPosition = transform.position.y;
        xPosition = Random.Range(xMin, xMax);
        zPosition = Random.Range(zMin, zMax);
        badguy.SetDestination(new Vector3(xPosition, yPosition, zPosition));
    }
}
