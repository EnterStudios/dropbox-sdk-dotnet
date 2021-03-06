// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Shared Paper document received.</para>
    /// </summary>
    public class NoteShareReceiveDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<NoteShareReceiveDetails> Encoder = new NoteShareReceiveDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<NoteShareReceiveDetails> Decoder = new NoteShareReceiveDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="NoteShareReceiveDetails" />
        /// class.</para>
        /// </summary>
        public NoteShareReceiveDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="NoteShareReceiveDetails" />.</para>
        /// </summary>
        private class NoteShareReceiveDetailsEncoder : enc.StructEncoder<NoteShareReceiveDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(NoteShareReceiveDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="NoteShareReceiveDetails" />.</para>
        /// </summary>
        private class NoteShareReceiveDetailsDecoder : enc.StructDecoder<NoteShareReceiveDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="NoteShareReceiveDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override NoteShareReceiveDetails Create()
            {
                return new NoteShareReceiveDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(NoteShareReceiveDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
