using UnityEngine;

public class RoadOffset : MonoBehaviour
{
    public Vector2 direction;

    public float speed = 3.0f;

    public Material roadMaterial;

    void Update()
    {
        roadMaterial.SetTextureOffset("_MainTex", (direction * speed) * Time.time);
    }
}
