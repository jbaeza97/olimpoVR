using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//=====================================//=====================================//
//== Main class                                                             ==//
//=====================================//=====================================//
public class MiniItemContainerController : MonoBehaviour
{
    //=================================//=====================================//
    //== Properties                                                         ==//
    //=================================//=====================================//
    public Transform   Anchor;
    public Transform[] CubeHolders;

    private GameObject[] ObjectsBeingHold;

    //=================================//=====================================//
    //== Unity virtual Methods                                              ==//
    //=================================//=====================================//

    //=================================//=====================================//
    //== Public Methods                                                     ==//
    //=================================//=====================================//
    public void HideCubes()
    {
        Anchor.localScale = Vector3.zero;
    }

    public void ShowCubes()
    {
        Anchor.localScale = Vector3.one;
    }

    public int SaveObject(GameObject _objectToStore)
    {
        int wasAbleToStore = -1;

        for (int i = 0; i < ObjectsBeingHold.Length; i++)
        {
            if (ObjectsBeingHold[i] == null)
            {
                ObjectsBeingHold[i] = _objectToStore;
                wasAbleToStore = i;
            }
        }

        return wasAbleToStore;
    }

    //=================================//=====================================//
    //== Private Methods                                                    ==//
    //=================================//=====================================//
    private void ContainerObject(GameObject _objectToStore)
    {
        //TODO
    }
}
