using System.Collections;
using System.Collections.Generic;
using UGG.Combat;
using UGG.Move;
using UnityEngine;

public abstract class StateActionSO : ScriptableObject
{
    [SerializeField] protected int statePriority;//状态优先级
    [HideInInspector] public Animator _animator;
    [HideInInspector] public CharacterMovementBase _movement;
    [HideInInspector] public CharacterCombatSystemBase _combatSystem;
    protected int verticalID; // 竖直方向的动画ID
    protected int horizontalID; // 水平方向的动画ID


    public virtual void OnEnter(StateMachineSystem stateMachineSystem) { }

    public abstract void OnUpdate();

    public virtual void OnExit() { }

    /// <summary>
    /// 获取状态优先级
    /// </summary>
    /// <returns></returns>
    public int GetStatePriority() => statePriority;

}
