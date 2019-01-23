using UnityEngine;
using UnityEditor.Graphing;

namespace UnityEditor.ShaderGraph
{
    [Title("Test")]
    class TestNode : AbstractMaterialNode, IGeneratesBodyCode, IGeneratesFunction
    {
        public TestNode()
        {
            name = "Test";
            UpdateNodeAfterDeserialization();
        }

        public sealed override void UpdateNodeAfterDeserialization()
        {
            AddSlot(new ShaderPort(0, "V1D", SlotType.Input, SlotValueType.Vector1, new Vector1Control(1.0f)));
            AddSlot(new ShaderPort(1, "V1", SlotType.Input, SlotValueType.Vector1));

            AddSlot(new ShaderPort(2, "V2D", SlotType.Input, SlotValueType.Vector2, new Vector2Control(Vector2.one)));
            AddSlot(new ShaderPort(3, "V2", SlotType.Input, SlotValueType.Vector2));

            AddSlot(new ShaderPort(4, "V3D", SlotType.Input, SlotValueType.Vector3, new Vector3Control(Vector3.one)));
            AddSlot(new ShaderPort(5, "V3", SlotType.Input, SlotValueType.Vector3));

            AddSlot(new ShaderPort(6, "V4D", SlotType.Input, SlotValueType.Vector4, new Vector4Control(Vector4.one)));
            AddSlot(new ShaderPort(7, "V4", SlotType.Input, SlotValueType.Vector4));

            AddSlot(new ShaderPort(8, "3ColorD", SlotType.Input, SlotValueType.Vector3, new ColorControl(Color.red, true)));
            AddSlot(new ShaderPort(9, "3Color", SlotType.Input, SlotValueType.Vector3, new ColorControl()));

            AddSlot(new ShaderPort(10, "4ColorD", SlotType.Input, SlotValueType.Vector4, new ColorControl(Color.red, true)));
            AddSlot(new ShaderPort(11, "4Color", SlotType.Input, SlotValueType.Vector4, new ColorControl()));

            AddSlot(new ShaderPort(12, "Bool", SlotType.Input, SlotValueType.Boolean, new ToggleControl(true)));
            AddSlot(new ShaderPort(13, "BoolD", SlotType.Input, SlotValueType.Boolean));

            AddSlot(new ShaderPort(14, "GradientD", SlotType.Input, SlotValueType.Gradient, new GradientControl(new Gradient() { colorKeys = new GradientColorKey[] { new GradientColorKey(Color.red, 0), new GradientColorKey(Color.blue, 1) }} )));
            AddSlot(new ShaderPort(15, "Gradient", SlotType.Input, SlotValueType.Gradient));

            AddSlot(new ShaderPort(16, "1Label", SlotType.Input, SlotValueType.Vector1, new LabelControl("Test")));

            AddSlot(new ShaderPort(17, "Texture2D", SlotType.Input, SlotValueType.Texture2D));
            AddSlot(new ShaderPort(18, "Texture3D", SlotType.Input, SlotValueType.Texture3D));
            AddSlot(new ShaderPort(19, "Texture2DArray", SlotType.Input, SlotValueType.Texture2DArray));
            AddSlot(new ShaderPort(20, "Cubemap", SlotType.Input, SlotValueType.Cubemap));

            AddSlot(new ShaderPort(21, "Sampler", SlotType.Input, SlotValueType.SamplerState));

            AddSlot(new ShaderPort(22, "Matrix2x2", SlotType.Input, SlotValueType.Matrix2));
            AddSlot(new ShaderPort(23, "Matrix3x3", SlotType.Input, SlotValueType.Matrix3));
            AddSlot(new ShaderPort(24, "Matrix4x4", SlotType.Input, SlotValueType.Matrix4));

            AddSlot(new ShaderPort(25, "V1PopupD", SlotType.Input, SlotValueType.Vector1, new PopupControl(new string[] {"Option A", "Option B", "Option C"}, 1)));
            AddSlot(new ShaderPort(26, "V1Popup", SlotType.Input, SlotValueType.Vector1, new PopupControl(new string[] {"Option A", "Option B", "Option C"})));

            AddSlot(new ShaderPort(27, "V1SliderD", SlotType.Input, SlotValueType.Vector1, new SliderControl(0.5f, 0.0f, 1.0f)));
            AddSlot(new ShaderPort(28, "V1Slider", SlotType.Input, SlotValueType.Vector1, new SliderControl()));

            AddSlot(new ShaderPort(29, "V1IntegerD", SlotType.Input, SlotValueType.Vector1, new IntegerControl(1)));
            AddSlot(new ShaderPort(30, "V1Integer", SlotType.Input, SlotValueType.Vector1, new IntegerControl()));
        }

        public void GenerateNodeCode(ShaderGenerator visitor, GraphContext graphContext, GenerationMode generationMode)
        {

        }

        public void GenerateNodeFunction(FunctionRegistry registry, GraphContext graphContext, GenerationMode generationMode)
        {

        }
    }
}
