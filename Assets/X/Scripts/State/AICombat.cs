using System.Collections;
using System.Collections.Generic;
using TMPro;
using UGG.Combat;
using UGG.Move;
using UnityEngine;


[CreateAssetMenu(fileName = "AICombat", menuName = "StateMachine/State/AICombat")]
public class AICombat : StateActionSO
{


    public override void OnUpdate()
    {
        Debug.Log("222222");
        NoCombat();
    }



    private void NoCombat()
    {

        //如果不能攻击就逃跑

        if (_animator.CheckAnimationTag("Motion"))
        {
            if (_combatSystem.GetCurrentTargetDistance() < 4.1 + 0.1f)
            {
                //往后退，不退挨打
                _movement.CharacterMoveInterface(-_movement.transform.forward, 1.5f, true);
                _animator.SetFloat(verticalID, -1f, 0.23f, Time.deltaTime);
                _animator.SetFloat(horizontalID, 0f, 0.1f, Time.deltaTime);


                if (_combatSystem.GetCurrentDistance() < 1.7 + 0.1f)
                        {
                          _animator.Play("Roll_B", 0, 0f);
                        }
            }
        }
    }
}
