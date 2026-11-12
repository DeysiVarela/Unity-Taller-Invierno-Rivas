using UnityEngine;

public class WheelSnowEffect : MonoBehaviour
{
    [SerializeField] private Material snowMaterial;
    [SerializeField] private Vector3 snowOffset = new Vector3(0f, 0.18f, 0f);
    [SerializeField] private Vector3 snowScale = new Vector3(0.45f, 0.12f, 0.35f);

    private void Start()
    {
        foreach (Transform child in GetComponentsInChildren<Transform>(true))
        {
            if (!child.name.StartsWith("P_Wheel") ||
                child.Find("Snow_Rim") != null)
            {
                continue;
            }

            CreateSnowRim(child);
        }
    }

    private void CreateSnowRim(Transform wheel)
    {
        GameObject snowRim = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        snowRim.name = "Snow_Rim";
        snowRim.transform.SetParent(wheel, false);
        snowRim.transform.localPosition = snowOffset;
        snowRim.transform.localScale = snowScale;

        Collider snowCollider = snowRim.GetComponent<Collider>();
        if (snowCollider != null)
        {
            Destroy(snowCollider);
        }

        MeshRenderer renderer = snowRim.GetComponent<MeshRenderer>();
        if (renderer != null && snowMaterial != null)
        {
            renderer.sharedMaterial = snowMaterial;
        }
    }
}
