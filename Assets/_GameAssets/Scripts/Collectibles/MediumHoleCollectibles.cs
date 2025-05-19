using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumHoleCollectibles : MonoBehaviour
{
    [SerializeField] private int deep;
    private MeshCollider mesh;
    void Start()
    {
        mesh = GetComponent<MeshCollider>();
    }

    void Update()
    {
        if (deep <= 0)
        {
            mesh.enabled = false;
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
