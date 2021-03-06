using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.AI;

public class EnemyUnit : MonoBehaviour
{
    public float Hitpoints = 10;

    [MenuItem("CONTEXT/EnemyUnit/Hit")]
    public static void TestHit(MenuCommand command)
    {
        var unit = (EnemyUnit)command.context;
        (unit).DoDamage(9.0f);
    }

    public bool IsAlive => Hitpoints > 0;

    public void DoDamage(float amount)
    {
        if (!IsAlive)
            return;
        var animator = GetComponent<Animator>();
        animator.Play("GetHit");
        Hitpoints -= amount;
        if(Hitpoints <= 0)
        {
            animator.CrossFade("Die", 0.2f);
            GetComponent<NavMeshAgent>().isStopped = true;
            Destroy(gameObject, 5.0f);
        }
        else
        {
            StartCoroutine(nameof(HandleHitAnimation));
        }
    }

    private IEnumerator HandleHitAnimation()
    {
        GetComponent<NavMeshAgent>().isStopped = true;
        yield return new WaitForSeconds(2f);
        if (IsAlive)
            GetComponent<NavMeshAgent>().isStopped = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
