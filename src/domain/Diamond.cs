﻿namespace Diamonds.Domain;
public class Diamond
{
    private const string LINE_BREAK = "\n";
    private readonly List<DiamondLine> _lines;

    public Diamond(List<DiamondLine> lines)
    {
        _lines = lines;
    }

    public string Print()
    {
        var upperLines = RenderLines();
        var renderedLines = upperLines.Concat(MirrorLines(upperLines));
        return string.Join(LINE_BREAK, renderedLines) + LINE_BREAK;
    }

    private IEnumerable<string> RenderLines() =>
        _lines.Select(x => x.ToString().TrimEnd());

    private static IEnumerable<string> MirrorLines(IEnumerable<string> renderedLines, int offset = 1) =>
        renderedLines.Reverse().Skip(offset);

}
