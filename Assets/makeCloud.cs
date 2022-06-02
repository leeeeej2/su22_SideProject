using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeCloud : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cloud;
    public GameObject cloud2;
    public GameObject cloud3;

    public float timer = 0;
    public float timeDiff = 1.5f;
    public float destoryTime = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        int whatType = 0;

        if(timer > timeDiff)
        {
            //x -10 ~ 10
            //y -15 ~ 15

            GameObject newCloud;

            whatType = Random.Range(0, 2);

            if(whatType == 0)
            {
                newCloud = Instantiate(cloud);
            }
            else if(whatType == 1)
            {
                newCloud = Instantiate(cloud2);
            }
            else
            {
                newCloud = Instantiate(cloud3);
            }

            newCloud.transform.position = new Vector3(Random.Range(-10f, 10f), Random.Range(-15f, 15f), Random.Range(25f, 35f));
            timer = 0;
            Destroy(cloud, destoryTime);
        }
    }
}