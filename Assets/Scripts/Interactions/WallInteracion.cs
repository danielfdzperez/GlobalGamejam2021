using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallInteracion : MonoBehaviour
{
    private MeshRenderer _myMeshRenderer;

    private void Start()
    {
        _myMeshRenderer = GetComponent<MeshRenderer>();
    }

    public void DisableWallVisibility(myPlayerNumber player)
    {
        if (player == myPlayerNumber.Player1)
            gameObject.layer = LayerMask.NameToLayer("Player1WallLayer");
        else
            gameObject.layer = LayerMask.NameToLayer("Player2WallLayer");

    }

    public void EnableWallVisibility(myPlayerNumber player)
    {
            gameObject.layer = LayerMask.NameToLayer("Default");
    }

}
