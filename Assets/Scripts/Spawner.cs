using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private Vector3 spawnlocation;
    public Transform MoveTarget;
    // Start is called before the first frame update
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 20), "Spawn"))
        {
            spawnlocation = gameObject.transform.position;

            for (int x = 0; x < 5; x++)
            {
                for (int z = 0; z < 5; z++)
                {
                    var spawnlocationCurrent = spawnlocation + new Vector3(x, 0, z);
                    Debug.Log(spawnlocationCurrent);
                    GameObject Enemy = Instantiate(prefab, spawnlocationCurrent, Quaternion.identity);
                    Enemy.GetComponent<Move>().goal = MoveTarget;

                }
            }
        }


    }

}
