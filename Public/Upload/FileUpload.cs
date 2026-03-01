using Payload.CMS.Internal.Contracts;

namespace Payload.CMS.Public.Upload;

/// <summary>
/// Represents a file to upload to a Payload CMS <c>upload</c> collection.
/// <para>Pass to the <c>file</c> parameter of <see cref="PayloadSDK.Create"/>,
/// <see cref="PayloadSDK.UpdateById"/>, or <see cref="PayloadSDK.Update"/>.</para>
/// </summary>
public sealed record FileUpload(byte[] Content, string FileName, string? MimeType = null) : IFileUpload;
