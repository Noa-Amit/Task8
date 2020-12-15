using UnityEngine;

/**
 * This component allows the player to move by clicking the arrow keys.
 */
public class KeyboardMover : MonoBehaviour {

    protected Vector3 NewPosition() {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            return transform.position + Vector3.left;
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            return transform.position + Vector3.right;
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            return transform.position + Vector3.down;
        } else if (Input.GetKeyDown(KeyCode.UpArrow)) {
            return transform.position + Vector3.up;
        } else {
            return transform.position;
        }
    }

    protected Vector3 NewPositionX()
    {
        if (Input.GetKey(KeyCode.X))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                return transform.position + Vector3.left;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                return transform.position + Vector3.right;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                return transform.position + Vector3.down;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                return transform.position + Vector3.up;
            }
            else
            {
                return transform.position;
            }
        }
        else
        {
            return transform.position;
        }
    }


    void Update()  {
        transform.position = NewPosition();
    }
}
