using System.Collections;
using System.Collections.Generic;
using NodeCanvas.Framework;
using Unity.VisualScripting;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public Blackboard blackboard;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter()
    {
        blackboard.SetVariableValue("GoalTrigger", true);
    }
}
