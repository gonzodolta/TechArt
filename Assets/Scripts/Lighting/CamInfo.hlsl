

void CalculateMainCamera_float(out float3 Direction) {
#if SHADERGRAPH_PREVIEW
    Direction = half3(0.5, 0.5, 0);
#else
    //Camera maincam = GameObject.Find("Main Camera").GetComponent<Camera>();
    Direction = Camera.main.transform.forward;
#endif
}

