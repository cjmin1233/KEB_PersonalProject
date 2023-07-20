using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HitBody : MonoBehaviour, IDamagable
{
    [SerializeField] private DamageType damageType;
    [SerializeField] private LivingEntity originBody;
    public void TakeDamage(DamageMessage damageMessage)
    {
        damageMessage.damageType = this.damageType;
        originBody.TakeDamage(damageMessage);
    }
}
