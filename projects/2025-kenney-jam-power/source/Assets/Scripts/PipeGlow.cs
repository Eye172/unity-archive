using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGlow : MonoBehaviour
{
    public Renderer pipeRenderer;

    private Material instanceMaterial;

    public Color energizedColor = Color.cyan;
    public float glowIntensity = 1.5f;

    void Start()
    {
        instanceMaterial = new Material(pipeRenderer.material);
        pipeRenderer.material = instanceMaterial;
        instanceMaterial.SetColor("_EmissionColor", Color.black);
    }

    public void Energize()
    {
        instanceMaterial.SetColor("_EmissionColor", energizedColor * glowIntensity);
    }

    public void ResetGlow()
    {
        instanceMaterial.SetColor("_EmissionColor", Color.black);
    }
}
