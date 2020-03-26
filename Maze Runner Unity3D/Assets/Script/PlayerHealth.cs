using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float Health;
    public Canvas HealthUICanvas;
    public Slider healthSlider;
    
    public playerMovementScript pm;
    public mouseLookScript ml;
    public spawnBOTScript sb;
    public cameraShakeScript shakeCam;
    public Animator EndGameAnimation;

    bool isRotate;

    private void Start()
    {
        healthSlider.maxValue = Health;
        healthSlider.value = Health;
    }

    private void Update()
    {
        healthSlider.value = Health;

        if(Health <= 0)
        {
            sb.enabled = ml.enabled = pm.enabled = false;
            HealthUICanvas.enabled = false;

            if (isRotate == false)
            {
                Cursor.lockState = CursorLockMode.None;
                StartCoroutine(shakeCam.Shake(0.5f, 0.3f));
                this.transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, 60f));
                isRotate = true;
                EndGameAnimation.SetBool("isEnd", true);
            }
        }
    }
}
