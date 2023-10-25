using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class PCMovementPlan : MonoBehaviour
{
    public UnityEvent<Vector3> drawMovementPlan;

    private Transform characterTransform;

    private List<Vector3> movePlanList = new List<Vector3>();
    // Start is called before the first frame update
    void Start()
    {
        characterTransform = transform.parent.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Debug.Log(characterTransform.position);
        movePlanList.Append<Vector3>(characterTransform.position);

        drawMovementPlan.Invoke(characterTransform.position);
    }
}
