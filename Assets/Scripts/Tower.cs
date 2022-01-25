using System.Collections.Generic;
using System.Collections;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Tower : MonoBehaviour
{
    public TowerData Data;

    private HashSet<EnemyUnit> _EnemiesInRange = new HashSet<EnemyUnit>();
    private EnemyUnit _CurrentTarget;
    private float _cooldown;


    public void Update()
    {
        if ((_cooldown -= Time.deltaTime) > 0)
            return;
        if (_EnemiesInRange.Count == 0)
            return;

        _CurrentTarget = _EnemiesInRange.Skip(Random.Range(0, _EnemiesInRange.Count)).FirstOrDefault(e => e.IsAlive);
        if (_CurrentTarget == null)
            return;

        _CurrentTarget.DoDamage(Data.Damage);
        _cooldown = Data.FireRate;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<EnemyUnit>() is { } unit)
            _EnemiesInRange.Add(unit);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<EnemyUnit>() is { } unit)
            _EnemiesInRange.Remove(unit);
    }
}
