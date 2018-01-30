Shader "Custom/SecretShader" {
	Properties 
	{
		_MainTex ("Texture", 2D) = "White" {}
	}
		SubShader 
	{
		Tags { "Queue" = "Transparent" "RenderType"="Transparent" }

		CGPROGRAM
		#pragma surface surf Standard alpha:fade

		struct Input 
		{
			float2 uv_MainTex;
		};

		sampler2D _MainTex;
		void surf (Input IN, inout SurfaceOutputStandard o) 
		{
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * fixed4(1,1,1,1);
			o.Albedo = c.rgb;
			o.Alpha = c.a * (1 - _LightColor0.a);
		}
		ENDCG
	}
}
