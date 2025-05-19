using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollectibles : MonoBehaviour
{
    private bool isCollected = false;
    private int index;

    [SerializeField] private PlayerInteractionController playerInteraction;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isCollected)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }
    public void ToTheHole()
    {
        playerInteraction.DecreaseHeight();
        transform.parent = null;
    }
    public void collectCube()
    {
        isCollected = true;
    }
    #region Helper Functions
    public bool GetCollectStatus()
    {
        return isCollected;
    }
    public void SetIndex(int newIndex)
    {
        index = newIndex;
    }
    #endregion
}
