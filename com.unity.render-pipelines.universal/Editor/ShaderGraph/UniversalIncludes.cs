﻿using UnityEditor.ShaderGraph.Internal;

namespace UnityEditor.Rendering.Universal.ShaderGraph
{
    static class UniversalIncludes
    {
        // Pre-graph
        const string kColor = "Packages/com.unity.render-pipelines.core/ShaderLibrary/Color.hlsl";
        const string kCore = "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl";
        const string kLighting = "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl";
        const string kShadows = "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Shadows.hlsl";
        const string kGraphFunctions = "Packages/com.unity.render-pipelines.universal/ShaderLibrary/ShaderGraphFunctions.hlsl";
        const string kMetaInput = "Packages/com.unity.render-pipelines.universal/ShaderLibrary/MetaInput.hlsl";
        const string k2DLightingUtil = "Packages/com.unity.render-pipelines.universal/Shaders/2D/Include/LightingUtility.hlsl";
        const string k2DNormal = "Packages/com.unity.render-pipelines.universal/Shaders/2D/Include/NormalsRenderingShared.hlsl";

        // Post-graph
        const string kVaryings = "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/Varyings.hlsl";
        const string kShaderPass = "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/ShaderPass.hlsl";
        const string kPBRForwardPass = "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/PBRForwardPass.hlsl";
        const string kDepthOnlyPass = "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/DepthOnlyPass.hlsl";
        const string kShadowCasterPass = "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/ShadowCasterPass.hlsl";
        const string kLightingMetaPass = "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/LightingMetaPass.hlsl";
        const string kPBR2DPass = "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/PBR2DPass.hlsl";
        const string kUnlitPass = "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/UnlitPass.hlsl";
        const string kSpriteLitPass = "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/SpriteLitPass.hlsl";
        const string kSpriteNormalPass = "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/SpriteNormalPass.hlsl";
        const string kSpriteForwardPass = "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/SpriteForwardPass.hlsl";
        const string kSpriteUnlitPass = "Packages/com.unity.render-pipelines.universal/Editor/ShaderGraph/Includes/SpriteUnlitPass.hlsl";

        public static IncludeCollection Forward = new IncludeCollection
        {
            // Pre-graph
            { kColor, IncludeLocation.Pregraph },
            { kCore, IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kShadows, IncludeLocation.Pregraph },
            { kGraphFunctions, IncludeLocation.Pregraph },

            // Post-graph
            { kShaderPass, IncludeLocation.Postgraph },
            { kVaryings, IncludeLocation.Postgraph },
            { kPBRForwardPass, IncludeLocation.Postgraph },
        };

        public static IncludeCollection DepthOnly = new IncludeCollection
        {
            // Pre-graph
            { kColor, IncludeLocation.Pregraph },
            { kCore, IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kGraphFunctions, IncludeLocation.Pregraph },

            // Post-graph
            { kShaderPass, IncludeLocation.Postgraph },
            { kVaryings, IncludeLocation.Postgraph },
            { kDepthOnlyPass, IncludeLocation.Postgraph },
        };

        public static IncludeCollection ShadowCaster = new IncludeCollection
        {
            // Pre-graph
            { kColor, IncludeLocation.Pregraph },
            { kCore, IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kGraphFunctions, IncludeLocation.Pregraph },

            // Post-graph
            { kShaderPass, IncludeLocation.Postgraph },
            { kVaryings, IncludeLocation.Postgraph },
            { kShadowCasterPass, IncludeLocation.Postgraph },
        };

        public static IncludeCollection Meta = new IncludeCollection
        {
            // Pre-graph
            { kColor, IncludeLocation.Pregraph },
            { kCore, IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kGraphFunctions, IncludeLocation.Pregraph },
            { kMetaInput, IncludeLocation.Pregraph },

            // Post-graph
            { kShaderPass, IncludeLocation.Postgraph },
            { kVaryings, IncludeLocation.Postgraph },
            { kLightingMetaPass, IncludeLocation.Postgraph },
        };

        public static IncludeCollection PBR2D = new IncludeCollection
        {
            // Pre-graph
            { kColor, IncludeLocation.Pregraph },
            { kCore, IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kGraphFunctions, IncludeLocation.Pregraph },

            // Post-graph
            { kShaderPass, IncludeLocation.Postgraph },
            { kVaryings, IncludeLocation.Postgraph },
            { kPBR2DPass, IncludeLocation.Postgraph },
        };

        public static IncludeCollection Unlit = new IncludeCollection
        {
            // Pre-graph
            { kColor, IncludeLocation.Pregraph },
            { kCore, IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kGraphFunctions, IncludeLocation.Pregraph },

            // Post-graph
            { kShaderPass, IncludeLocation.Postgraph },
            { kVaryings, IncludeLocation.Postgraph },
            { kUnlitPass, IncludeLocation.Postgraph },
        };

        public static IncludeCollection SpriteLit = new IncludeCollection
        {
            // Pre-graph
            { kColor, IncludeLocation.Pregraph },
            { kCore, IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kGraphFunctions, IncludeLocation.Pregraph },
            { k2DLightingUtil, IncludeLocation.Pregraph },

            // Post-graph
            { kShaderPass, IncludeLocation.Postgraph },
            { kVaryings, IncludeLocation.Postgraph },
            { kSpriteLitPass, IncludeLocation.Postgraph },
        };

        public static IncludeCollection SpriteNormal = new IncludeCollection
        {
            // Pre-graph
            { kColor, IncludeLocation.Pregraph },
            { kCore, IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kGraphFunctions, IncludeLocation.Pregraph },
            { k2DNormal, IncludeLocation.Pregraph },

            // Post-graph
            { kShaderPass, IncludeLocation.Postgraph },
            { kVaryings, IncludeLocation.Postgraph },
            { kSpriteNormalPass, IncludeLocation.Postgraph },
        };

        public static IncludeCollection SpriteForward = new IncludeCollection
        {
            // Pre-graph
            { kColor, IncludeLocation.Pregraph },
            { kCore, IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kGraphFunctions, IncludeLocation.Pregraph },

            // Post-graph
            { kShaderPass, IncludeLocation.Postgraph },
            { kVaryings, IncludeLocation.Postgraph },
            { kSpriteForwardPass, IncludeLocation.Postgraph },
        };

        public static IncludeCollection SpriteUnlit = new IncludeCollection
        {
            // Pre-graph
            { kColor, IncludeLocation.Pregraph },
            { kCore, IncludeLocation.Pregraph },
            { kLighting, IncludeLocation.Pregraph },
            { kGraphFunctions, IncludeLocation.Pregraph },

            // Post-graph
            { kShaderPass, IncludeLocation.Postgraph },
            { kVaryings, IncludeLocation.Postgraph },
            { kSpriteUnlitPass, IncludeLocation.Postgraph },
        };
    }
}
