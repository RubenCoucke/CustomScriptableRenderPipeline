﻿using UnityEditor.ShaderGraph.Internal;

namespace UnityEditor.Rendering.Universal.ShaderGraph
{
    static class UniversalStructs
    {
        public static StructDescriptor Varyings = new StructDescriptor()
        {
            name = "Varyings",
            packFields = true,
            fields = new FieldDescriptor[]
            {
                StructFields.Varyings.positionCS,
                StructFields.Varyings.positionWS,
                StructFields.Varyings.normalWS,
                StructFields.Varyings.tangentWS,
                StructFields.Varyings.texCoord0,
                StructFields.Varyings.texCoord1,
                StructFields.Varyings.texCoord2,
                StructFields.Varyings.texCoord3,
                StructFields.Varyings.color,
                StructFields.Varyings.viewDirectionWS,
                StructFields.Varyings.bitangentWS,
                StructFields.Varyings.screenPosition,
                UniversalStructFields.Varyings.lightmapUV,
                UniversalStructFields.Varyings.sh,
                UniversalStructFields.Varyings.fogFactorAndVertexLight,
                UniversalStructFields.Varyings.shadowCoord,
                StructFields.Varyings.instanceID,
                StructFields.Varyings.cullFace,
            }
        };
    }
}
