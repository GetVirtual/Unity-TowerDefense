using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private Vector3 spawnlocation;
    // Start is called before the first frame update
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 20), "Spawn"))
        {
            spawnlocation = new Vector3(7, -16, 43);

            for (int x = 0; x < 5; x++)
            {
                for (int z = 0; z < 5; z++)
                {
                    spawnlocation = new Vector3((7 + x), -14.85f, (43 + z));
                    Debug.Log(spawnlocation);
                    GameObject Enemy = Instantiate(prefab, spawnlocation, Quaternion.identity);

                }
            }
        }


    }

}
