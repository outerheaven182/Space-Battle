using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject leader = GameObject.FindGameObjectWithTag("leader");
        GameObject teaser = GameObject.FindGameObjectWithTag("teaser");

        leader.GetComponent<StateMachine>().SwicthState(new IdleState(leader, teaser));
        teaser.GetComponent<StateMachine>().SwicthState(new TeaseState(teaser, leader));  
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
