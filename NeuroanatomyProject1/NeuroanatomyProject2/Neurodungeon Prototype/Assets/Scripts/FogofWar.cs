using UnityEngine;
using System.Collections;
public class FogOfWar : MonoBehaviour
{
    //hello
    IEnumerator Destroy ()
    {
        yield return new WaitForSeconds(1.3f);
        Destroy(gameObject);
    }
}
