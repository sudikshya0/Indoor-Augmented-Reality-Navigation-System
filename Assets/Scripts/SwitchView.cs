using UnityEngine;
using System.Collections;
using UnityEngine.UI;
// Attach this script to the AR camera
public class SwitchView : MonoBehaviour
{
   
    public GameObject startbutton;
    public Transform targetToFollow;    // The transform of the gameobject that gets followed
    public Quaternion targetRot;
    public RawImage minimap;            // The rawimage the view of the camera gets rendered to
    public float rotationSmoothingSpeed = 1.5f;
    public Camera fullscreenCamera;
    public GameObject switchButton;     // Button that switches the views
    public GameObject text;

    private bool map = false;           // boolean to tell if map is showing (phone position)
    private bool pressed = false;       // boolean to tell if map is showing (button press)
    private RenderTexture texture;      // field to save texture to set again after view switch

    // Use lateUpdate to assure that the camera is updated after the target has been updated.
    void LateUpdate()
    {
        if (!targetToFollow)
            return;
        //receive rotation from camera
        Vector3 targetEulerAngles = targetRot.eulerAngles;

        //switch view when phone is turned horizontal
        if (targetRot.x > 0.5)
        {
            if (!map)
            {
                //show mapview 
                map = true;
                gameObject.GetComponent<Camera>().enabled = false;
                minimap.gameObject.SetActive(false);
                texture = fullscreenCamera.targetTexture;
                fullscreenCamera.targetTexture = null;
                fullscreenCamera.orthographicSize = 15;
              
                switchButton.SetActive(false);
            }
        }
        else
        {
            if (map)
            {
                //show cameraview
                map = false;
                gameObject.GetComponent<Camera>().enabled = true;
                minimap.gameObject.SetActive(true);
                fullscreenCamera.targetTexture = texture;
                fullscreenCamera.orthographicSize = 7;
               
                switchButton.SetActive(true);
            }
        }
        // Calculate the current rotation angle around the Y axis we want to apply to the camera.
        // We add 180 degrees as the device camera points to the negative Z direction
        float rotationToApplyAroundY = targetEulerAngles.y; //+ 180;
        
    }

    // switch button is pressed
    public void Switch()
    {
        if (!pressed)
        {
            //show mapview
            pressed = true;
            gameObject.GetComponent<Camera>().enabled = false;
            minimap.gameObject.SetActive(false);
            texture = fullscreenCamera.targetTexture;
            fullscreenCamera.targetTexture = null;
            fullscreenCamera.orthographicSize = 15;
           
        }
        else
        {
            //show cameraview
            pressed = false;
            gameObject.GetComponent<Camera>().enabled = true;
            minimap.gameObject.SetActive(true);
            fullscreenCamera.targetTexture = texture;
            fullscreenCamera.orthographicSize = 7;
           
        }
    }

   public void Onclick()
    {
        text.SetActive(false);
        startbutton.SetActive(false);
    }
}
