using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleCollectibles : MonoBehaviour
{
    [SerializeField] private int deep;

    void Update()
    {
        if (deep <= 0)
        {
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == Consts.Tag.COLLECTIBLES && deep>=0)
        {
            if (other.gameObject.TryGetComponent<CubeCollectibles>(out var cube))
            {
                cube.ToTheHole();
            }
            deep-=1;
        }
    }
    public int GetDeep()
    {
        return deep;
    }
}
