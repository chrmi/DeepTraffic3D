using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateGround : MonoBehaviour {
    float index = 0f;

    void Start()
    {
        StartCoroutine(updateTiling());
    }

    private IEnumerator updateTiling()
    {
        while (true)
        {
            Vector2 offset = new Vector2(0, index);
            GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
            index += 0.05f;
            if (index > 0.95f)
            {
                index = 0f;
            }
            yield return new WaitForSeconds(1f / 15f);
        }

    }
}
