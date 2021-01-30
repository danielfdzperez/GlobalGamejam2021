using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraComponent : MonoBehaviour
{

    public PlayerInformation _myPlayer;

    private WallInteracion lastWall;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        Vector3 v = _myPlayer.transform.position - transform.position;

        if (Physics.Raycast(transform.position, v.normalized, out hit, v.magnitude))
        {
            Debug.DrawRay(transform.position, v.normalized * v.magnitude, Color.red);
            if (hit.collider.GetComponent<WallInteracion>())
            {

                if (lastWall != hit.collider.GetComponent<WallInteracion>())
                {
                    if (lastWall != null)
                        lastWall.EnableWallVisibility(_myPlayer._myPlayerNumber);
                    lastWall = hit.collider.GetComponent<WallInteracion>();
                    lastWall.DisableWallVisibility(_myPlayer._myPlayerNumber);
                }

            }

            else if(lastWall)
            {
                DisableWallVisibility();
            }
        }
        else if (lastWall)
        {
            DisableWallVisibility();
        }
    }


    private void DisableWallVisibility()
    {
        lastWall.EnableWallVisibility(_myPlayer._myPlayerNumber);
        lastWall = null;
    }

}
