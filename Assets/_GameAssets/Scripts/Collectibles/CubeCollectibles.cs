using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollectibles : MonoBehaviour
{
    private bool isCollected = false;
    private int index;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void collectCube()
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
