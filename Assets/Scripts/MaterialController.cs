using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialController : MonoBehaviour {

    // Properties
    public Material material;
    public bool animationIsActive = false;
    public float animationTimeTotal = 1;

    // Animation Variables
    private float animationRatio = 0;
    private float animationTime = 0;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (animationIsActive) {
            animationTime += Time.deltaTime;
            animationTime %= animationTimeTotal;
            Lerp(animationTime / animationTimeTotal);
        }
    }

    private void Lerp(float pRatio) {

        Vector2 offset = new Vector2(0, pRatio);
        material.SetTextureOffset("_MainTex", offset);
        //material.mainTextureOffset = offset;
        
    }
}
