using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Color = UnityEngine.Color;



public class Init : MonoBehaviour
{

    private GameObject BoxClone;
    public GameObject BulletPF;
    // Start is called before the first frame update
    void Start()
    {
        Fire();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Fire()
    {

        for(int i = 0; i < 10; i++)
            for (int j = 0; j < 10; j++)
                for (int k   = 0; k < 10; k ++)
                {
                Vector3 NewPos = new Vector3(1.2f*i, 1.1f * j, 1.2f * k);
                    

                    BoxClone = Instantiate(BulletPF, NewPos, transform.rotation);
                    var color1 = (int)Random.Range(0, 255);
                    var color2 = (int)Random.Range(0, 255);
                    var color3 = (int)Random.Range(0, 255);
                    //                   var df = new UnityEngine.Color(color1 / 255.0f, color2 / 255.0f, color3 / 255.0f);
                    var ColorN = new UnityEngine.Color(color1 / 255.0f, color2 / 255.0f, color3 / 255.0f);
                    var Rend2 = BoxClone.GetComponent<Renderer>();
                    Rend2.material.SetColor("_Color", ColorN);

                    Destroy(BoxClone, 125.5f);
                }




        






    }

}
