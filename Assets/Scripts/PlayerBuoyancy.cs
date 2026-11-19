using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class PlayerBuoyancy : MonoBehaviour
{
    public WaterSurface waterSurface;
    public Rigidbody rb;
    private float floatHeightOffset = 0.5f;
    private float buoyancyStrength = 15.0f;
    private float waterDrag = 5.0f;
    public bool inWater = false;
    public bool touchingWater = false;
    
    private WaterSearchParameters searchParameters;
    private WaterSearchResult searchResult;

    void FixedUpdate()
    {
        if (waterSurface == null) return;
        
        searchParameters.startPositionWS = transform.position;
        searchParameters.targetPositionWS = transform.position;
        searchParameters.error = 0.01f;
        searchParameters.maxIterations = 8;

        if (waterSurface.ProjectPointOnWaterSurface(searchParameters, out searchResult))
        {
            float waterHeight = searchResult.projectedPositionWS.y;
            float depth = waterHeight - transform.position.y + floatHeightOffset;

            if (depth > 0)
            {
                // Debug.Log("depth="+depth);
                rb.AddForce(Vector3.up * (depth * buoyancyStrength), ForceMode.Acceleration);
                rb.linearDamping = waterDrag;
                // Debug.Log("Adding buoyancy force");
                inWater = true;
            }
            else
            {
                rb.linearDamping = 0.05f;
                inWater = false;
            }

            if (waterHeight - transform.position.y + 1.1 > 0) touchingWater = true;
            else touchingWater = false;
                
        }
        
        
    }
    
}
