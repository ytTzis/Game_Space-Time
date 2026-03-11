using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UGG.Combat;

public class AIlogic : CharacterCombatSystemBase
{
    [SerializeField,Header("·¶Î§¼ì²â")] private Transform detectCenter;
    [SerializeField] private float detectionRang;
    [SerializeField] LayerMask whatisEnemy;
    [SerializeField] private LayerMask whatisBos;

    Collider[] colliderTarget = new Collider[1];
    [SerializeField, Header("Ä¿±ê")] private Transform currentTarget;
        
    private void Update()
    {
        AIView();
    }

    private void AIView()
    {
        int targetCount = Physics.OverlapSphereNonAlloc(detectCenter.position, detectionRang, colliderTarget, whatisEnemy);
        if (targetCount > 0)
        {
            if (!Physics.Raycast((transform.root.position + transform.root.up * 0.5f), (colliderTarget[0].transform.position - transform.root.position).normalized, out var hit, detectionRang, whatisBos))
            {
                if (Vector3.Dot((colliderTarget[0].transform.position - transform.root.position).normalized, transform.root.forward) > 0.35f)
                { 
                    currentTarget = colliderTarget[0].transform;
                }
            }
        }
    }


    public Transform GetCurrentTarget()
    {   
        if (currentTarget == null)
            return null;

        return currentTarget;
        
    }

    public float GetCurrentTargetDistance() => Vector3.Distance(currentTarget.position, transform.root.position);
}

