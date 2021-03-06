// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The metadata of a shared link.</para>
    /// </summary>
    /// <seealso cref="FileLinkMetadata" />
    /// <seealso cref="FolderLinkMetadata" />
    public class SharedLinkMetadata
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedLinkMetadata> Encoder = new SharedLinkMetadataEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedLinkMetadata> Decoder = new SharedLinkMetadataDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedLinkMetadata" />
        /// class.</para>
        /// </summary>
        /// <param name="url">URL of the shared link.</param>
        /// <param name="name">The linked file name (including extension). This never contains
        /// a slash.</param>
        /// <param name="linkPermissions">The link's access permissions.</param>
        /// <param name="id">A unique identifier for the linked file.</param>
        /// <param name="expires">Expiration time, if set. By default the link won't
        /// expire.</param>
        /// <param name="pathLower">The lowercased full path in the user's Dropbox. This always
        /// starts with a slash. This field will only be present only if the linked file is in
        /// the authenticated user's  dropbox.</param>
        /// <param name="teamMemberInfo">The team membership information of the link's owner.
        /// This field will only be present  if the link's owner is a team member.</param>
        /// <param name="contentOwnerTeamInfo">The team information of the content's owner.
        /// This field will only be present if the content's owner is a team member and the
        /// content's owner team is different from the link's owner team.</param>
        protected SharedLinkMetadata(string url,
                                     string name,
                                     LinkPermissions linkPermissions,
                                     string id = null,
                                     sys.DateTime? expires = null,
                                     string pathLower = null,
                                     TeamMemberInfo teamMemberInfo = null,
                                     global::Dropbox.Api.Users.Team contentOwnerTeamInfo = null)
        {
            if (url == null)
            {
                throw new sys.ArgumentNullException("url");
            }

            if (name == null)
            {
                throw new sys.ArgumentNullException("name");
            }

            if (linkPermissions == null)
            {
                throw new sys.ArgumentNullException("linkPermissions");
            }

            if (id != null)
            {
                if (id.Length < 1)
                {
                    throw new sys.ArgumentOutOfRangeException("id", "Length should be at least 1");
                }
            }

            this.Url = url;
            this.Name = name;
            this.LinkPermissions = linkPermissions;
            this.Id = id;
            this.Expires = expires;
            this.PathLower = pathLower;
            this.TeamMemberInfo = teamMemberInfo;
            this.ContentOwnerTeamInfo = contentOwnerTeamInfo;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedLinkMetadata" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedLinkMetadata()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is File</para>
        /// </summary>
        public bool IsFile
        {
            get
            {
                return this is FileLinkMetadata;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a <see cref="FileLinkMetadata" />, or
        /// <c>null</c>.</para>
        /// </summary>
        public FileLinkMetadata AsFile
        {
            get
            {
                return this as FileLinkMetadata;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Folder</para>
        /// </summary>
        public bool IsFolder
        {
            get
            {
                return this is FolderLinkMetadata;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a <see cref="FolderLinkMetadata" />, or
        /// <c>null</c>.</para>
        /// </summary>
        public FolderLinkMetadata AsFolder
        {
            get
            {
                return this as FolderLinkMetadata;
            }
        }

        /// <summary>
        /// <para>URL of the shared link.</para>
        /// </summary>
        public string Url { get; protected set; }

        /// <summary>
        /// <para>The linked file name (including extension). This never contains a
        /// slash.</para>
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// <para>The link's access permissions.</para>
        /// </summary>
        public LinkPermissions LinkPermissions { get; protected set; }

        /// <summary>
        /// <para>A unique identifier for the linked file.</para>
        /// </summary>
        public string Id { get; protected set; }

        /// <summary>
        /// <para>Expiration time, if set. By default the link won't expire.</para>
        /// </summary>
        public sys.DateTime? Expires { get; protected set; }

        /// <summary>
        /// <para>The lowercased full path in the user's Dropbox. This always starts with a
        /// slash. This field will only be present only if the linked file is in the
        /// authenticated user's  dropbox.</para>
        /// </summary>
        public string PathLower { get; protected set; }

        /// <summary>
        /// <para>The team membership information of the link's owner.  This field will only be
        /// present  if the link's owner is a team member.</para>
        /// </summary>
        public TeamMemberInfo TeamMemberInfo { get; protected set; }

        /// <summary>
        /// <para>The team information of the content's owner. This field will only be present
        /// if the content's owner is a team member and the content's owner team is different
        /// from the link's owner team.</para>
        /// </summary>
        public global::Dropbox.Api.Users.Team ContentOwnerTeamInfo { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedLinkMetadata" />.</para>
        /// </summary>
        private class SharedLinkMetadataEncoder : enc.StructEncoder<SharedLinkMetadata>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedLinkMetadata value, enc.IJsonWriter writer)
            {
                if (value is FileLinkMetadata)
                {
                    WriteProperty(".tag", "file", writer, enc.StringEncoder.Instance);
                    FileLinkMetadata.Encoder.EncodeFields((FileLinkMetadata)value, writer);
                    return;
                }
                if (value is FolderLinkMetadata)
                {
                    WriteProperty(".tag", "folder", writer, enc.StringEncoder.Instance);
                    FolderLinkMetadata.Encoder.EncodeFields((FolderLinkMetadata)value, writer);
                    return;
                }
                WriteProperty("url", value.Url, writer, enc.StringEncoder.Instance);
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                WriteProperty("link_permissions", value.LinkPermissions, writer, global::Dropbox.Api.Sharing.LinkPermissions.Encoder);
                if (value.Id != null)
                {
                    WriteProperty("id", value.Id, writer, enc.StringEncoder.Instance);
                }
                if (value.Expires != null)
                {
                    WriteProperty("expires", value.Expires.Value, writer, enc.DateTimeEncoder.Instance);
                }
                if (value.PathLower != null)
                {
                    WriteProperty("path_lower", value.PathLower, writer, enc.StringEncoder.Instance);
                }
                if (value.TeamMemberInfo != null)
                {
                    WriteProperty("team_member_info", value.TeamMemberInfo, writer, global::Dropbox.Api.Sharing.TeamMemberInfo.Encoder);
                }
                if (value.ContentOwnerTeamInfo != null)
                {
                    WriteProperty("content_owner_team_info", value.ContentOwnerTeamInfo, writer, global::Dropbox.Api.Users.Team.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedLinkMetadata" />.</para>
        /// </summary>
        private class SharedLinkMetadataDecoder : enc.UnionDecoder<SharedLinkMetadata>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedLinkMetadata" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedLinkMetadata Create()
            {
                return new SharedLinkMetadata();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override SharedLinkMetadata Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "file":
                        return FileLinkMetadata.Decoder.DecodeFields(reader);
                    case "folder":
                        return FolderLinkMetadata.Decoder.DecodeFields(reader);
                    default:
                        return base.Decode(reader);
                }
            }
            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedLinkMetadata value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "url":
                        value.Url = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "link_permissions":
                        value.LinkPermissions = global::Dropbox.Api.Sharing.LinkPermissions.Decoder.Decode(reader);
                        break;
                    case "id":
                        value.Id = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "expires":
                        value.Expires = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    case "path_lower":
                        value.PathLower = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "team_member_info":
                        value.TeamMemberInfo = global::Dropbox.Api.Sharing.TeamMemberInfo.Decoder.Decode(reader);
                        break;
                    case "content_owner_team_info":
                        value.ContentOwnerTeamInfo = global::Dropbox.Api.Users.Team.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
