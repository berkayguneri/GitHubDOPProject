using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonStunnedState : EnemyState
{
    private Enemy_Skeleton enemy;
    public SkeletonStunnedState(Enemy _enemyBase, EnemyStateMachine enemyStateMachine, string _animBoolName, Enemy_Skeleton _enemy) : base(_enemyBase, enemyStateMachine, _animBoolName)
    {
        this.enemy = _enemy;
    }

    public override void Enter()
    {
        base.Enter();
        enemy.fX.InvokeRepeating("RedColorBlink",0,.1f);

        stateTimer = enemy.stunDuration;
        rb.velocity=new Vector2(-enemy.facingDirection * enemy.stunDir.x, enemy.stunDir.y);
    }

    public override void Exit()
    {
        base.Exit();
        enemy.fX.Invoke("CancelColorChange", 0);
    }

    public override void Update()
    {
        base.Update();
        if (stateTimer < 0)
            stateMachine.ChangeState(enemy.idleState);
    }
}
