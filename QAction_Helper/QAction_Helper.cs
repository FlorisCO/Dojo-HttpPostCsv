// <auto-generated>This is auto-generated code by DIS. Do not modify.</auto-generated>
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Skyline.DataMiner.Scripting
{
public static class Parameter
{
	/// <summary>PID: 400 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int csvContent_400 = 400;
	/// <summary>PID: 400 | Type: read</summary>
	public const int csvContent = 400;
	/// <summary>PID: 410 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int sessionAuthorization_410 = 410;
	/// <summary>PID: 410 | Type: read</summary>
	public const int sessionAuthorization = 410;
	/// <summary>PID: 420 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int sessionResponseStatusCode_420 = 420;
	/// <summary>PID: 420 | Type: read</summary>
	public const int sessionResponseStatusCode = 420;
	/// <summary>PID: 422 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int sessionResponseContentType_422 = 422;
	/// <summary>PID: 422 | Type: read</summary>
	public const int sessionResponseContentType = 422;
	/// <summary>PID: 424 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int sessionResponseContent_424 = 424;
	/// <summary>PID: 424 | Type: read</summary>
	public const int sessionResponseContent = 424;
	public class Write
	{
		/// <summary>PID: 100 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int triggercsvpost_100 = 100;
		/// <summary>PID: 100 | Type: write</summary>
		public const int triggercsvpost = 100;
		/// <summary>PID: 401 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int csvContent_401 = 401;
		/// <summary>PID: 401 | Type: write</summary>
		public const int csvContent = 401;
		/// <summary>PID: 411 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int sessionAuthorization_411 = 411;
		/// <summary>PID: 411 | Type: write</summary>
		public const int sessionAuthorization = 411;
	}
}
public class WriteParameters
{
	/// <summary>PID: 100  | Type: write | DISCREETS: Post = 1</summary>
	public System.Object Triggercsvpost {get { return Protocol.GetParameter(100); }set { Protocol.SetParameter(100, value); }}
	/// <summary>PID: 401  | Type: write</summary>
	public System.Object CsvContent {get { return Protocol.GetParameter(401); }set { Protocol.SetParameter(401, value); }}
	/// <summary>PID: 411  | Type: write</summary>
	public System.Object SessionAuthorization {get { return Protocol.GetParameter(411); }set { Protocol.SetParameter(411, value); }}
	public SLProtocolExt Protocol;
	public WriteParameters(SLProtocolExt protocol)
	{
		Protocol = protocol;
	}
}
public interface SLProtocolExt : SLProtocol
{
	object Triggercsvpost_100 { get; set; }
	object Triggercsvpost { get; set; }
	object CsvContent_400 { get; set; }
	object CsvContent { get; set; }
	object CsvContent_401 { get; set; }
	object SessionAuthorization_410 { get; set; }
	object SessionAuthorization { get; set; }
	object SessionAuthorization_411 { get; set; }
	object SessionResponseStatusCode_420 { get; set; }
	object SessionResponseStatusCode { get; set; }
	object SessionResponseContentType_422 { get; set; }
	object SessionResponseContentType { get; set; }
	object SessionResponseContent_424 { get; set; }
	object SessionResponseContent { get; set; }
	WriteParameters Write { get; set; }
}
public class ConcreteSLProtocolExt : ConcreteSLProtocol, SLProtocolExt
{
	/// <summary>PID: 100  | Type: write | DISCREETS: Post = 1</summary>
	public System.Object Triggercsvpost_100 {get { return GetParameter(100); }set { SetParameter(100, value); }}
	/// <summary>PID: 100  | Type: write | DISCREETS: Post = 1</summary>
	public System.Object Triggercsvpost {get { return Write.Triggercsvpost; }set { Write.Triggercsvpost = value; }}
	/// <summary>PID: 400  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object CsvContent_400 {get { return GetParameter(400); }set { SetParameter(400, value); }}
	/// <summary>PID: 400  | Type: read</summary>
	public System.Object CsvContent {get { return GetParameter(400); }set { SetParameter(400, value); }}
	/// <summary>PID: 401  | Type: write</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object CsvContent_401 {get { return GetParameter(401); }set { SetParameter(401, value); }}
	/// <summary>PID: 410  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object SessionAuthorization_410 {get { return GetParameter(410); }set { SetParameter(410, value); }}
	/// <summary>PID: 410  | Type: read</summary>
	public System.Object SessionAuthorization {get { return GetParameter(410); }set { SetParameter(410, value); }}
	/// <summary>PID: 411  | Type: write</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object SessionAuthorization_411 {get { return GetParameter(411); }set { SetParameter(411, value); }}
	/// <summary>PID: 420  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object SessionResponseStatusCode_420 {get { return GetParameter(420); }set { SetParameter(420, value); }}
	/// <summary>PID: 420  | Type: read</summary>
	public System.Object SessionResponseStatusCode {get { return GetParameter(420); }set { SetParameter(420, value); }}
	/// <summary>PID: 422  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object SessionResponseContentType_422 {get { return GetParameter(422); }set { SetParameter(422, value); }}
	/// <summary>PID: 422  | Type: read</summary>
	public System.Object SessionResponseContentType {get { return GetParameter(422); }set { SetParameter(422, value); }}
	/// <summary>PID: 424  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object SessionResponseContent_424 {get { return GetParameter(424); }set { SetParameter(424, value); }}
	/// <summary>PID: 424  | Type: read</summary>
	public System.Object SessionResponseContent {get { return GetParameter(424); }set { SetParameter(424, value); }}
	public WriteParameters Write { get; set; }
	public ConcreteSLProtocolExt()
	{
		Write = new WriteParameters(this);
	}
}
}
