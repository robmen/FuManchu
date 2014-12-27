﻿namespace FuManchu.Renderer
{
	using System.IO;
	using FuManchu.Parser.SyntaxTree;
	using FuManchu.Text;

	/// <summary>
	/// Renders text to the output writer.
	/// </summary>
	public class TextSpanRenderer : SpanRenderer
	{
		/// <inheritdoc />
		public override void Render(Span target, RenderContext context, TextWriter writer)
		{
			string content = target == null || target.Content == null ? string.Empty : target.Content;

			Write(context, writer, new RawString(content));
		}
	}
}