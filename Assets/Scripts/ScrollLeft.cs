using UnityEngine;

public class ScrollLeft : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    public float scrollSpeed = .125f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0);
    }
}
