using UnityEngine;
 
public class LevelTriggerRestart: MonoBehaviour
{
     void OnTriggerEnter(Collider leader)
     {
          Application.LoadLevel("Start");
     }
}