using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ToCombatCondition", menuName = "StateMachine/Condition/ToCombatCondition")]
public class ToCombatCondition : ConditionSO
{
    private AIlogic _combatSystem;
    public override bool ConditionSetUp()
    {
        return (_combatSystem.GetCurrentTarget() != null) ? true : false;
    }

    public override void Init(StateMachineSystem stateSystem)
    {
        _combatSystem = stateSystem.transform.root.GetComponentInChildren<AIlogic>();
    }
}
    