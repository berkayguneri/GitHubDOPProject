using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonDeadState : EnemyState
{
    private Enemy_Skeleton enemy;
    public SkeletonDeadState(Enemy _enemyBase, EnemyStateMachine enemyStateMachine, string _animBoolName, Enemy_Skeleton _enemy) : base(_enemyBase, enemyStateMachine, _animBoolName)
    {
        this.enemy = _enemy;
    }

    public override void Enter()
    {
        base.Enter();
        AudioManager.instance.PlaySFX(20, null);

        enemy.anim.SetBool(enemy.lastAnimBoolName, true);
        enemy.anim.speed = 0;
        enemy.cd.enabled = false;

        stateTimer = .15f;
    }

   

    public override void Update()
    {
        base.Update();
        if(stateTimer > 0)
        {
            rb.velocity = new Vector2(0, 10);
        }
        
    }
}
