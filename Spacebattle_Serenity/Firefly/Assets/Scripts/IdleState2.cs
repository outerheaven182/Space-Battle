/*using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class IdleState2:State
{
	static Vector3 initialPos = Vector3.zero;
	static Vector3 Randomised = new Vector3(Random.Range(-400, 400), Random.Range(-400, 400), Random.Range(-400, 400));

	
	GameObject enemyGameObject;
	//public int xmin = -400;
	//public int xmax = 400;
	//public int ymin = -400;
	//public int ymax = 400;
	//public int zmin = -400;
	//public int zmax = 400;


	
    public override string Description()
    {
        return "Idle State 2";
    }

    public IdleState2(GameObject myGameObject, GameObject enemyGameObject)
        : base(myGameObject)
    {
        this.enemyGameObject = enemyGameObject;
    }

    public override void Enter()
    {
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(Randomised);
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(Randomised);
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(Randomised);
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(Randomised);
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(Randomised);
		myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(Randomised);
		//myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(0, 0, -10));
        myGameObject.GetComponent<SteeringBehaviours>().path.Looped = true;            
        myGameObject.GetComponent<SteeringBehaviours>().path.draw = true;
        myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();
        myGameObject.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;
    }
    public override void Exit()
    {
        myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Clear();
    }

    public override void Update()
    {
        float range2 = 5.0f;           
        // Can I see the enemy?
        if ((enemyGameObject.transform.position - myGameObject.transform.position).magnitude < range2)
        {
            // Is the leader inside my FOV
            myGameObject.GetComponent<StateMachine>().SwicthState(new AttackingState(myGameObject, enemyGameObject));
        }
    }
}
*/