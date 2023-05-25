using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Enemy")
        {
            Destroy(Other.gameObject);
        }
    }

}



