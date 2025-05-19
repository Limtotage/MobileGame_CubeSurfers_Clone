using UnityEngine;

public class PlayerInteractionController : MonoBehaviour
{
    [SerializeField] private GameObject sphere;
    [SerializeField] private Transform Cameratransform;
    private int height = 0;

    void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    private void UpToDoSky()
    {
        sphere.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
        transform.localPosition = new Vector3(0, -height, 0);
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == Consts.Tag.COLLECTIBLES)
        {
            if (other.gameObject.TryGetComponent<CubeCollectibles>(out var cubeCollectibles))
            {
                if (!cubeCollectibles.GetCollectStatus())
                {
                    height += 1;
                    cubeCollectibles.collectCube();
                    cubeCollectibles.SetIndex(height);
                    if (other.gameObject.TryGetComponent<Transform>(out var tranform))
                    {
                        tranform.parent = sphere.transform;
                    }
                    UpToDoSky();
                }
            }
        }
    }
    public void DecreaseHeight()
    {
        height -= 1;
        UpToDoSky();
    }
}