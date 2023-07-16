using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asansorscrpt : MonoBehaviour
{
    public Animator asansorAnim;
    public bool box2 = false;
    public bool box3 = false;



    private void Update()
    {
        if (box2 && box3)
        {
            asansorAnim.ResetTrigger("Kapat");

            asansorAnim.SetTrigger("Aç");

        }

        else if (!(box2 && box3))
        {
            asansorAnim.ResetTrigger("Aç");

            asansorAnim.SetTrigger("Kapat");
        }
    }
}
