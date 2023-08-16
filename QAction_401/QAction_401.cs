using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using Skyline.DataMiner.Scripting;

/// <summary>
/// DataMiner QAction Class: CreateMultipart.
/// </summary>
public static class QAction
{
	public const string Boundary = "------------------------74bd4318f823d8cb";

	/// <summary>
	/// The QAction entry point.
	/// </summary>
	/// <param name="protocol">Link with SLProtocol process.</param>
	public static void Run(SLProtocol protocol)
	{
		try
		{
			var value = Convert.ToString(protocol.GetParameter(Parameter.Write.csvContent_401));
			protocol.SetParameter(Parameter.csvMultipartContent_402, ToMultipartContent(value, "csv", "file.csv", "text/csv"));
		}
		catch (Exception ex)
		{
			protocol.Log("QA" + protocol.QActionID + "|" + protocol.GetTriggerParameter() + "|Run|Exception thrown:" + Environment.NewLine + ex, LogType.Error, LogLevel.NoLogging);
		}
	}

	private static string ToMultipartContent(string value, string name, string filename, string type)
	{
		var sb = new StringBuilder();

		sb.Append("--");
		sb.AppendLine(Boundary);

		sb.Append("Content-Disposition: form-data; name=\"").Append(name).Append("\"; ");
		sb.Append("filename=\"").Append(filename).AppendLine("\"");

		sb.Append("Content-Type: ").AppendLine(type);

		sb.AppendLine();
		sb.AppendLine(value);

		sb.Append("--").Append(Boundary).AppendLine("--");

		return sb.ToString();
	}
}