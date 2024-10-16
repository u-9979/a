using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandomPosition : MonoBehaviour
{
    [SerializeField]
    private GameObject createPrefab;

    [SerializeField]
    private Transform rangeA; 

    [SerializeField]
    private Transform rangeB;

    //経過時間
    private float time;


    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;  

        if(time>1.0f)
        {
            float x = Random.Range(rangeA.position.x,rangeB.position.x);

            float y = Random.Range(rangeA.position.y,rangeB.position.y);

            float z = Random.Range(rangeA.position.z,rangeB.position.z);

            GameObject obj = Instantiate(createPrefab,new Vector3(x,y,z),createPrefab.transform.rotation);

            time = 0f;
            
            Destroy(obj,1.0f);
        }
        
    }
}
