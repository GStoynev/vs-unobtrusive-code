namespace UnobtrusiveCode
{
    using Microsoft.VisualStudio.Text.Classification;
    using Microsoft.VisualStudio.Utilities;

    using System.ComponentModel.Composition;

    using static UnobtrusiveCodePackage;

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = ObtrusiveCodeClassification)]
    [Name(ObtrusiveCodeClassification)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    public class ObtrusiveCodeFormatDefinition : ClassificationFormatDefinition
    {
        public ObtrusiveCodeFormatDefinition()
        {
            ForegroundOpacity = CurrentOptions.DimmingOpacity;
            BackgroundOpacity = CurrentOptions.DimmingOpacity;

            DisplayName = ObtrusiveCodeClassification;
        }

        [Export]
        [Name(ObtrusiveCodeClassification)]
        internal static ClassificationTypeDefinition ObtrusiveCodeTypeDefinition = null;
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = ObtrusiveCodeClassificationHovered)]
    [Name(ObtrusiveCodeClassificationHovered)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    public class ObtrusiveCodeHoveredFormatDefinition : ClassificationFormatDefinition
    {
        public ObtrusiveCodeHoveredFormatDefinition()
        {
            ForegroundOpacity = CurrentOptions.DimmingOpacityHovered;
            BackgroundOpacity = CurrentOptions.DimmingOpacityHovered;

            DisplayName = ObtrusiveCodeClassificationHovered;
        }

        [Export]
        [Name(ObtrusiveCodeClassificationHovered)]
        internal static ClassificationTypeDefinition ObtrusiveCodeHoveredTypeDefinition = null;
    }
}
