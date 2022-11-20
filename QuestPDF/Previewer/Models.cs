﻿using System.Collections.Generic;
using QuestPDF.Drawing;
using QuestPDF.Infrastructure;

namespace QuestPDF.Previewer;

internal sealed class DocumentElementProperty
{
    public string Label { get; set; }
    public string Value { get; set; }
}

internal sealed class Size
{
    public float Width { get; set; }
    public float Height { get; set; }
}

internal sealed class SpacePlan
{
    public float Width { get; set; }
    public float Height { get; set; }
    public SpacePlanType Type { get; set; }
}

internal sealed class LayoutRenderingTrace
{
    public string ElementType { get; set; }
    public IReadOnlyCollection<DocumentElementProperty> ElementProperties { get; set; }
    public Size AvailableSpace { get; set; }
    public SpacePlan SpacePlan { get; set; }
    public IReadOnlyCollection<LayoutRenderingTrace> Children { get; set; }
}
