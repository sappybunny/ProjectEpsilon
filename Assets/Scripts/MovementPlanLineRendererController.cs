using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class MovementPlanLineRendererController : MonoBehaviour
{

    [SerializeField]
    private LineRenderer lr;
    [SerializeField]
    private GameObject planPointPrefab;

    private int nextPointIndex = 0;
    private List<GameObject> planPoints = new List<GameObject>();

    private CircleCollider2D colliderToAdd;
    private SpriteRenderer pointSpriteToAdd;


    // Start is called before the first frame update
    void Start()
    {
        // Preparing point sprite to add
        pointSpriteToAdd = new SpriteRenderer();
        pointSpriteToAdd.color = Color.white;
    }

    // Adds most recently collected point to the line renderer to be drawn
    public void drawMovementPlan(Vector3 pointToAdd)
    {
        lr.positionCount++;
        lr.SetPosition(nextPointIndex, pointToAdd);
        

        // Every (5) points (ie: 10/s) add a 2D circle collider to the point
        if (nextPointIndex % ConfigInternal.planPointsPerClickablePoint == 0)
        {
            // Instantiate the plan point and give it the correct position Vector3
            planPoints.Add(Instantiate(planPointPrefab));
            planPoints[planPoints.Count - 1].transform.position = pointToAdd;


        }




        this.nextPointIndex += 1;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
