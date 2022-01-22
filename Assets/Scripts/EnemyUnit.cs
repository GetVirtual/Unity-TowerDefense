using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EnemyUnit : MonoBehaviour
{
    public float Hitpoints = 10;

    [MenuItem("CONTEXT/EnemyUnit/Hit")]
    public static void TestHit(MenuCommand command)
    {
        var unit = (EnemyUnit)command.context;
        (unit).DoDamage(unit.Hitpoints);
    }

    public void DoDamage(float amount)
    {
        GetComponent<Animator>().Play("GetHit");
        Hitpoints -= amount;
        if(Hitpoints <= 0)
        {
            GetComponent<Animator>().Play("GetHit");
            Destroy(gameObject, 1.0f);
        }
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
