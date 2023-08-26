using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Phaycollider : MonoBehaviour
{
    public GameObject dan;
    private int soDan = 5;//so dan hien tai

    private int maxSoDan = 5;//so dan toi da
    private bool isNapDan = false;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nhanVatBanDan();
    }

    private void nhanVatBanDan()
    {
        // bắn tốidđa 5 viên đạn
        if (Input.GetKeyDown(KeyCode.F))
        {
            
            if (soDan > 0 && !isNapDan)
            {
                transform.Translate(Vector3.left  * Time.deltaTime);
                
                Instantiate(dan, transform.position, transform.rotation);
                soDan--;    
            }
            else if(soDan == 0 && isNapDan)
            {
                isNapDan = true;
                soDan = maxSoDan;
                isNapDan = false;
            }
        }
        // nạp đạn
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (soDan == 0 && !isNapDan)
            {
                isNapDan = true;
                soDan = maxSoDan;
                isNapDan = false;
            }
        }


    }
}
